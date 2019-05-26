using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Project
{
    public partial class frmEnd : Form
    {
        public frmEnd()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.
        }

        private int p1OverallPropMoney, p2OverallPropMoney;//, wonBy;
        private bool foundWinner = false;
        private Player winner;

        private void frmEnd_Load(object sender, EventArgs e)
        {
            Highscore.newHighScore(Game.Players[0].Name, Game.Players[0].Score);
            Highscore.newHighScore(Game.Players[1].Name, Game.Players[1].Score);

            pnlPlayer1.BackColor = Game.Players[0].Colour;
            pnlPlayer2.BackColor = Game.Players[1].Colour;

            picP1Avatar.Image = Game.Players[0].Avatar;
            picP1Avatar.BackColor = Color.White;
            picP2Avatar.Image = Game.Players[1].Avatar;
            picP2Avatar.BackColor = Color.White;

            lblP1Username.Text = Game.Players[0].Name;
            lblP2Username.Text = Game.Players[1].Name;

            lblP1Money.Text = "Finished with $" + Game.Players[0].Money;
            lblP2Money.Text = "Finished with $" + Game.Players[1].Money;

            lblP1QuestionScore.Text = "Correct Questions: " + Game.Players[0].Score;
            lblP2QuestionScore.Text = "Correct Questions: " + Game.Players[1].Score;

            lblP1AmountofProperties.Text = "Total Properties: " + Game.Players[0].PropertyCount;
            lblP2AmountofProperties.Text = "Total Properties: " + Game.Players[1].PropertyCount;

            lblP1TimeInJail.Text = "Times Gone to Jail: " + Game.Players[0].GoneToJail;
            lblP2TimeInJail.Text = "Times Gone to Jail: " + Game.Players[1].GoneToJail;

            while(!foundWinner)
            {
                foundWinner = findWinner();
            }

            if(winner == null)
            {
                picWinner.Visible = false;
                lblGameWinner.Visible = false;
                lblWinnerName.Text = "There is no winner!";
                lblCongrats.Text = "You decided to end the game early.";
            }
            else
            {
                picWinner.Image = winner.Avatar;
                lblWinnerName.Text = winner.Name;
                pnlWinner.BackColor = winner.Colour;
            }
        }

        private bool findWinner()
        {
            // Step 1 - Work with Money
            //wonBy = 1;

            if (Game.Players[0].Money < 0)
            {
                winner = Game.Players[1];
                return true;
            }
            
            if(Game.Players[1].Money < 0)
            {
                winner = Game.Players[0];
                return true;
            }

            // Step 2 - Question Score
            //wonBy = 2;

            if (Game.Players[0].Score > Game.Players[1].Score)
            {
                winner = Game.Players[0];
                return true;
            }
            else if (Game.Players[0].Score < Game.Players[1].Score)
            {
                winner = Game.Players[1];
                return true;
            }

            // Step 3 - Find Properties
            //wonBy = 3;

            if(Game.Players[0].PropertyCount > Game.Players[1].PropertyCount)
            {
                winner = Game.Players[0];
                return true;
            }
            else if (Game.Players[0].PropertyCount < Game.Players[1].PropertyCount)
            {
                winner = Game.Players[1];
                return true;
            }

            // Step 4 - Work out Prices
            //wonBy = 4;
            if (Game.Players[0].PropertyCount > 1 || Game.Players[1].PropertyCount > 1)
            {
                foreach (Property prop in Game.AllProperties)
                {
                    if (prop.Owner == Game.Players[0])
                    {
                        p1OverallPropMoney += prop.Cost;
                    }

                    if (prop.Owner == Game.Players[1])
                    {
                        p2OverallPropMoney += prop.Cost;
                    }
                }

                if ((Game.Players[0].Money + p1OverallPropMoney) > (Game.Players[1].Money + p2OverallPropMoney))
                {
                    winner = Game.Players[0];
                    return true;
                }
                else if ((Game.Players[0].Money + p1OverallPropMoney) < (Game.Players[1].Money + p2OverallPropMoney))
                {
                    winner = Game.Players[1];
                    return true;
                }
            }

            winner = null;
            return true;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

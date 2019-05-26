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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.
        }

        Player p1 = new Player(), p2 = new Player();

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(dropPlayer1Colour.SelectedIndex.ToString());
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtPlayer1Name.Text) && !string.IsNullOrWhiteSpace(txtPlayer2Name.Text))
            {
                if(p1.Avatar != null && p2.Avatar != null)
                {
                    if (dropPlayer1Colour.SelectedIndex != dropPlayer2Colour.SelectedIndex)
                    {
                        if (dropPlayer1Colour.SelectedIndex >= 0 && dropPlayer2Colour.SelectedIndex >= 0)
                        {
                            p1.Name = txtPlayer1Name.Text;
                            p2.Name = txtPlayer2Name.Text;

                            p1.Token = Properties.Resources.P1Token;
                            p2.Token = Properties.Resources.P2Token;

                            Game.AddPlayers(p1, p2);

                            this.Hide();
                            frmBoard game = new frmBoard();
                            game.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid colour from the list.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Players needs to have different colours!");
                    }
                }
                else
                {
                    MessageBox.Show("Players need to have an avatar.");
                }
            }
            else
            {
                MessageBox.Show("Players need to have a valid name.");
            }
                        
        }

        private void picFemaleAvatarP1_Click(object sender, EventArgs e)
        {
            picFemaleAvatarP1.BackColor = Color.LightPink;
            picMaleAvatarP1.BackColor = Color.Transparent;
            p1.Avatar = picFemaleAvatarP1.Image;
        }

        private void picMaleAvatarP1_Click(object sender, EventArgs e)
        {
            picFemaleAvatarP1.BackColor = Color.Transparent;
            picMaleAvatarP1.BackColor = Color.LightBlue;
            p1.Avatar = picMaleAvatarP1.Image;
        }

        private void picFemaleAvatarP2_Click(object sender, EventArgs e)
        {
            picFemaleAvatarP2.BackColor = Color.LightPink;
            picMaleAvatarP2.BackColor = Color.Transparent;
            p2.Avatar = picFemaleAvatarP2.Image;
        }

        private void picMaleAvatarP2_Click(object sender, EventArgs e)
        {
            picFemaleAvatarP2.BackColor = Color.Transparent;
            picMaleAvatarP2.BackColor = Color.LightBlue;
            p2.Avatar = picMaleAvatarP2.Image;
        }

        private void dropPlayer1Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropPlayer1Colour.SelectedIndex)
            {
                case 0:
                    p1.Colour = Color.LightBlue;
                    break;
                case 1:
                    p1.Colour = Color.LightPink;
                    break;
                case 2:
                    p1.Colour = Color.LightYellow;
                    break;
                case 3:
                    p1.Colour = Color.Lime;
                    break;
                case 4:
                    p1.Colour = Color.IndianRed;
                    break;
                default:
                    p1.Colour = Color.LightGray;
                    break;

            }
        }

        private void dropPlayer2Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropPlayer2Colour.SelectedIndex)
            {
                case 0:
                    p2.Colour = Color.LightBlue;
                    break;
                case 1:
                    p2.Colour = Color.LightPink;
                    break;
                case 2:
                    p2.Colour = Color.LightYellow;
                    break;
                case 3:
                    p2.Colour = Color.Lime;
                    break;
                case 4:
                    p2.Colour = Color.IndianRed;
                    break;
                default:
                    p2.Colour = Color.LightGray;
                    break;

            }
        }
    }
}

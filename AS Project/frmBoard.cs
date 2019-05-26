using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Project
{
    public partial class frmBoard : Form
    {
        //bool isThereAWinner = false;
        Player winner;

        public static PictureBox[] boardPositions = new PictureBox[28];
        Property[] boardProperties = new Property[25];

        //int PlayerCount = 2;
        //Player p1 = new Player();
        //Player p2 = new Player();
        //Player[] Players = new Player[] { p1, p2 };
        int pTurn = 0, mroll;
        bool noQuestions = false;
        //List<Player> Players = new List<Player>();

        Random random = new Random();

        public frmBoard()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.

        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            adminToolStripMenuItem.Visible = false; // This was the debug admin tool to give me quicker testing

            lblP1isInJail.Visible = false;
            lblP2isInJail.Visible = false;

            lblP1IsTurn.Visible = true;
            lblP2IsTurn.Visible = false;

            updatePlayers();
            LoadBoardDesign();

            Game.Players[0].Position = 0;
            Game.Players[1].Position = 0;
            boardPositions[Game.Players[0].Position].Image = Properties.Resources.NS2;
        }

        private void updatePlayers()
        { // Method to update players information, such as cash and score.
            lblP1Username.Text = Game.Players[0].Name;
            lblP2Username.Text = Game.Players[1].Name;

            picP1Avatar.Image = Game.Players[0].Avatar;
            picP1Avatar.BackColor = Color.White;
            picP2Avatar.Image = Game.Players[1].Avatar;
            picP2Avatar.BackColor = Color.White;

            picP1Token.Image = Game.Players[0].Token;
            picP2Token.Image = Game.Players[1].Token;

            pnlPlayer1.BackColor = Game.Players[0].Colour;
            pnlPlayer2.BackColor = Game.Players[1].Colour;

            lblP1Money.Text = "$" + Game.Players[0].Money;
            lblP2Money.Text = "$" + Game.Players[1].Money;

            lblP1QuestionScore.Text = "Score: " + Game.Players[0].Score;
            lblP2QuestionScore.Text = "Score: " + Game.Players[1].Score;

            lblP1AmountofProperties.Text = "Owned Properties: " + Game.Players[0].PropertyCount;
            lblP2AmountofProperties.Text = "Owned Properties: " + Game.Players[1].PropertyCount;

            if (Game.Players[0].IsInJail)
            {
                lblP1isInJail.Visible = true;
                lblP1isInJail.Text = "Currently in Jail.";
            }
            else
            {
                lblP1isInJail.Visible = false;
            }

            if (Game.Players[1].IsInJail)
            {
                lblP2isInJail.Visible = true;
                lblP2isInJail.Text = "Currently in Jail.";
            }
            else
            {
                lblP2isInJail.Visible = false;
            }

            checkMoney();
        }

        private void checkMoney()
        {
            if (Game.Players[0].Money < 0)
            {
                //isThereAWinner = true;
                winner = Game.Players[1];
                endGame();
            }
            else if (Game.Players[1].Money < 0)
            {
                //isThereAWinner = true;
                winner = Game.Players[0];
                endGame();
            }
        }

        private void endGame()
        {
            //MessageBox.Show("Game Over! " + winner.Name + " is the Winner!");
            this.Hide();
            frmEnd endform = new frmEnd();
            endform.ShowDialog();
            this.Close();
        }

        private void LoadBoardDesign()
        {
            // Board Dimensions: 542, 542

            boardProperties = Game.AllProperties;

            // Corner Blocks
            boardPositions[0] = EventHandler.CreatePictureBox("picPosGo", new Point(442, 492), new Size(100, 100));
            boardPositions[7] = EventHandler.CreatePictureBox("picPosJailJustPassing", new Point(442, 50), new Size(100, 100));
            boardPositions[14] = EventHandler.CreatePictureBox("picPosFreeParking", new Point(884, 50), new Size(100, 100));
            boardPositions[21] = EventHandler.CreatePictureBox("picPosGoToJail", new Point(884, 492), new Size(100, 100));
            
            // Southern Board
            boardPositions[27] = EventHandler.CreatePictureBox("picPosHackerWay", new Point(548, 492), new Size(50, 100));
            boardPositions[26] = EventHandler.CreatePictureBox("picPosZuckerbergLane", new Point(604, 492), new Size(50, 100));
            boardPositions[25] = EventHandler.CreatePictureBox("picPosBernersLeeWay", new Point(660, 492), new Size(50, 100));
            boardPositions[24] = EventHandler.CreatePictureBox("picPosLinusLane", new Point(716, 492), new Size(50, 100));
            boardPositions[23] = EventHandler.CreatePictureBox("picPosGatesStreet", new Point(772, 492), new Size(50, 100));
            boardPositions[22] = EventHandler.CreatePictureBox("picPosOsborneGardens", new Point(828, 492), new Size(50, 100));
            
            // Eastern Board
            boardPositions[20] = EventHandler.CreatePictureBox("picPosSystromBoulevard", new Point(884, 437), new Size(100, 50));
            boardPositions[19] = EventHandler.CreatePictureBox("picPosChamberlinLane", new Point(884, 380), new Size(100, 50));
            boardPositions[18] = EventHandler.CreatePictureBox("picPosGoslingWay", new Point(884, 324), new Size(100, 50));
            boardPositions[17] = EventHandler.CreatePictureBox("picPosRobertsAvenue", new Point(884, 268), new Size(100, 50));
            boardPositions[16] = EventHandler.CreatePictureBox("picPosMinerGardens", new Point(884, 212), new Size(100, 50));
            boardPositions[15] = EventHandler.CreatePictureBox("picPosGabenStreet", new Point(884, 156), new Size(100, 50));

            // Northern Board
            boardPositions[13] = EventHandler.CreatePictureBox("picPosCerfWay", new Point(829, 50), new Size(50, 100));
            boardPositions[12] = EventHandler.CreatePictureBox("picPosBlokBoulevard", new Point(772, 50), new Size(50, 100));
            boardPositions[11] = EventHandler.CreatePictureBox("picPosJobsLane", new Point(716, 50), new Size(50, 100));
            boardPositions[10] = EventHandler.CreatePictureBox("picPosPageGardens", new Point(660, 50), new Size(50, 100));
            boardPositions[9] = EventHandler.CreatePictureBox("picPosPerssonStreet", new Point(604, 50), new Size(50, 100));
            boardPositions[8] = EventHandler.CreatePictureBox("picPosHejlsbergWay", new Point(548, 50), new Size(50, 100));

            // Western Board
            boardPositions[6] = EventHandler.CreatePictureBox("picPosWozniakStreet", new Point(442, 156), new Size(100, 50));
            boardPositions[5] = EventHandler.CreatePictureBox("picPosRossumLane", new Point(442, 212), new Size(100, 50));
            boardPositions[4] = EventHandler.CreatePictureBox("picPosKildallBoulevard", new Point(442, 268), new Size(100, 50));
            boardPositions[3] = EventHandler.CreatePictureBox("picPosRubinStreet", new Point(442, 324), new Size(100, 50));
            boardPositions[2] = EventHandler.CreatePictureBox("picPosBrinGardens", new Point(442, 380), new Size(100, 50));
            boardPositions[1] = EventHandler.CreatePictureBox("picPosDorseyWay", new Point(442, 437), new Size(100, 50));
            
            for (int pos = 0; pos < boardPositions.Length; pos++)
            {
                Controls.Add(boardPositions[pos]);
            }
        }

        #region Debugging
        private void propertyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmProperty property = new frmProperty(Game.Players[pTurn], boardProperties[1]))
            {
                DialogResult result = property.ShowDialog();
                while (result != DialogResult.OK)
                {
                    MessageBox.Show("Error! The form seems to have went missing...");
                    result = property.ShowDialog();
                }

                if (result == DialogResult.OK)
                {
                    if (property.isValidSelection == true)
                    {
                        property.isValidSelection = false;
                    }

                    updatePlayers();
                }
            }
        }

        private void player1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < boardProperties.Length; i++)
            {
                boardProperties[i].Owner = Game.Players[0];
            }
        }

        private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < boardProperties.Length; i++)
            {
                boardProperties[i].Owner = Game.Players[1];
            }
        }

        private void questionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //TODO : Button Click for Roll -> Load method Roll();
            using (frmQuestion question = new frmQuestion(Game.Players[pTurn]))
            {
                DialogResult result = question.ShowDialog();
                while (result != DialogResult.OK)
                {
                    MessageBox.Show("Error! The form seems to have went missing...");
                    result = question.ShowDialog();
                }

                if (result == DialogResult.OK)
                {
                    bool allowedToRoll = false;

                    if (question.answeredQuestion == true)
                    {
                        Game.Players[pTurn].Score += 1;
                        question.answeredQuestion = false;
                        allowedToRoll = true;

                        if (allowedToRoll == true)
                        {
                            //Roll();
                            allowedToRoll = false;
                        }
                    }

                    updatePlayers();
                }
            }
        }

        private void player1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pTurn = 0;
        }

        private void player2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pTurn = 1;
        }

        private void currentPlayerNearJailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boardPositions[Game.Players[pTurn].Position].Image = null;
            Game.Players[pTurn].Position = 20;
            boardPositions[Game.Players[pTurn].Position].Image = Game.Players[pTurn].Avatar;
        }


        //private void addPlayersToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Game.AddPlayersToDB(Game.Players[0], Game.Players[1]);
        //    MessageBox.Show("Users added to database.");
        //}

        private void closeDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void removePlayerToken()
        {
            if (Game.Players[0].Position == Game.Players[1].Position)
            {
                if (Game.Players[pTurn].Position >= 0 && Game.Players[pTurn].Position < 7 || Game.Players[pTurn].Position >= 14 && Game.Players[pTurn].Position < 21)
                {
                    // player is on east / west board
                    if (pTurn == 0)
                    {
                        // set position to remove p1 from picturebox
                        boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.EW1;
                    }
                    else
                    {
                        // set position to remove p2 from picturebox
                        boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.EW0;
                    }
                }
                else if (Game.Players[pTurn].Position >= 7 && Game.Players[pTurn].Position < 14 || Game.Players[pTurn].Position >= 21 && Game.Players[pTurn].Position < 28)
                {
                    // player is on south / north board
                    if (pTurn == 0)
                    {
                        // set position to remove p1 from picturebox
                        boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.NS1;
                    }
                    else
                    {
                        // set position to remove p2 from picturebox
                        boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.NS0;
                    }
                }
            }
            else
            {
                try
                {
                    boardPositions[Game.Players[pTurn].Position].Image = null;
                }
                catch (Exception) { }
            }
        }

        private void setPlayerToken()
        {
            if (Game.Players[0].Position == Game.Players[1].Position)
            {
                if (Game.Players[pTurn].Position >= 0 && Game.Players[pTurn].Position < 7 || Game.Players[pTurn].Position >= 14 && Game.Players[pTurn].Position < 21)
                {
                    // player is on east / west board
                    boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.EW2;
                }
                else if (Game.Players[pTurn].Position >= 7 && Game.Players[pTurn].Position < 14 || Game.Players[pTurn].Position >= 21 && Game.Players[pTurn].Position < 28)
                {
                    // player is on south / north board
                    boardPositions[Game.Players[pTurn].Position].Image = Properties.Resources.NS2;
                }
            }
            else
            {
                try
                {
                    boardPositions[Game.Players[pTurn].Position].Image = Game.Players[pTurn].Token;
                }
                catch (Exception) { }
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            using (frmQuestion question = new frmQuestion(Game.Players[pTurn]))
            {
                DialogResult questionFormResult = question.ShowDialog();
                while (questionFormResult != DialogResult.OK)
                {
                    MessageBox.Show("Well... that question just disappeared. Lets try that again.");
                    questionFormResult = question.ShowDialog();
                }

                if (questionFormResult == DialogResult.OK)
                {
                    if (question.answeredQuestion == true)
                    {
                        if(question.outOfQuestions && !noQuestions)
                        {
                            MessageBox.Show("Out of Questions.");
                            question.outOfQuestions = false;
                            noQuestions = true;
                        }

                        if (Game.Players[pTurn].IsInJail)
                        {
                            Game.Players[pTurn].JailDuration = Game.Players[pTurn].JailDuration + 1;
                        }

                        Game.Players[pTurn].Score += 1;
                        question.answeredQuestion = false;

                        if (!Game.Players[pTurn].IsInJail)
                        {
                            using(frmRollDice roll = new frmRollDice())
                            {
                                DialogResult result = roll.ShowDialog();
                                if(result == DialogResult.OK)
                                {
                                    mroll = roll.roll;
                                }
                            }

                            removePlayerToken();

                            Game.Players[pTurn].Position = Game.Players[pTurn].Position + mroll;

                            if (Game.Players[pTurn].Position >= 27)
                            {
                                if (Game.Players[pTurn].Position > 27)
                                {
                                    PlayerPassedGo();
                                }

                                Game.Players[pTurn].Position = Game.Players[pTurn].Position - 27;
                            }

                            setPlayerToken();

                            using (frmProperty property = new frmProperty(Game.Players[pTurn], boardProperties[Game.Players[pTurn].Position]))
                            {
                                DialogResult answerFormResult = property.ShowDialog();
                                while (answerFormResult != DialogResult.OK)
                                {
                                    MessageBox.Show("Well... Properties have to be bought, and Rents have to be paid.\nYou just can't \"x\" the problem away...");
                                    answerFormResult = property.ShowDialog();
                                }

                                if (answerFormResult == DialogResult.OK)
                                {
                                    if (property.isValidSelection == true)
                                    {
                                        property.isValidSelection = false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (Game.Players[pTurn].JailDuration >= 3)
                            {
                                Game.Players[pTurn].IsInJail = false;
                                Game.Players[pTurn].JailDuration = 0;
                            }

                            if (Game.Players[pTurn].IsInJail)
                            {
                                using (frmProperty property = new frmProperty(Game.Players[pTurn], boardProperties[Game.Players[pTurn].Position]))
                                {
                                    DialogResult answerFormResult = property.ShowDialog();
                                    if (answerFormResult != DialogResult.OK)
                                    {
                                        MessageBox.Show("I guess you don't want to bail then..");
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (pTurn >= (Game.Players.Count - 1))
            {
                pTurn = 0;
                lblP1IsTurn.Visible = true;
                lblP2IsTurn.Visible = false;
            }
            else
            {
                pTurn++;
                lblP1IsTurn.Visible = false;
                lblP2IsTurn.Visible = true;
            }

            updatePlayers();
        }

        private void PlayerPassedGo()
        {
            using (frmProperty passedGo = new frmProperty(Game.Players[pTurn], boardProperties[0]))
            {
                passedGo.hasPassedGo = true;

                DialogResult passedGoForm = passedGo.ShowDialog();
                if (passedGoForm != DialogResult.OK)
                {
                    MessageBox.Show("Guess you don't want your $500. Thats fine with me.");
                    passedGoForm = passedGo.ShowDialog();
                }
            }
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the game?", "Leaving so early?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frmEnd end = new frmEnd();
                end.Show();
            }
        }

        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Highscore.highscore[0].Item2 + " currently holds the high score with:\nQuestion Score: " + Highscore.highscore[0].Item1);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to start a new game?", "New Game?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the game?", "Leaving so early?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frmEnd end = new frmEnd();
                end.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check whos turn it is by looking in the player information area.\nClick the \"Roll Dice\" button to get a question.\nAnswer the question correctly to roll the dice.\nYour token will be moved the amount of spaces the dice show.\nYou can choose to buy the property if it is unowned. Otherwise you have to pay the rent.\nEnd your turn and let the next player begin their turn.");
            //try
            //{
            //    Process.Start("userguide.docx");
            //}
            //catch(System.IO.FileNotFoundException)
            //{
            //    MessageBox.Show("Unable to find help file... did the game install properly?");
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("There was an error loading the file.");
            //}
        }

        private void tmrTokenCheck_Tick(object sender, EventArgs e)
        {
            removePlayerToken();
            setPlayerToken();
        }


    }
}

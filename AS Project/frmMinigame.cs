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
    public partial class frmMinigame : Form
    {
        Player PlayingPlayer;
        int MoneyCount = 0;

        int timeLeft = 30; // seconds

        Random random = new Random();
        int MinigameNo = 0; // 2 is pacman

        public frmMinigame(Player Player)
        {
            InitializeComponent();
            PlayingPlayer = Player; // Load Player Details

            MinigameNo = random.Next(1, 3); // 1 or 2
        }

        private void frmMinigame_Load(object sender, EventArgs e)
        {
            LoadPlayer();
            lblTimeLeft.Text = "Time Left\n" + Convert.ToString(timeLeft) + " seconds";

            switch(MinigameNo)
            {
                case 1:
                    LoadMatching();
                    break;
                case 2:
                    LoadPacman();
                    break;
                default:
                    this.Close();
                    break;
            }

            tmrGameTimer.Start();
        }

        #region Player Stats and Details

        private void LoadPlayer()
        {
            lblUsername.Text = PlayingPlayer.Name;
            picUserAvatar.Image = PlayingPlayer.Avatar;
            UpdateMoneyCount();
        }

        private void UpdateMoneyCount()
        {
            lblMoneyCount.Text = "Collected Money: $" + Convert.ToString(MoneyCount);
        }

        #endregion
        
        #region Match Money

        private void LoadMatching()
        {
            //throw new NotImplementedException();
            UpdateMoneyCount();
        }

        #endregion

        #region Pac Man Money Hunt

        private void LoadPacman()
        {
            //throw new NotImplementedException();
            UpdateMoneyCount();
        }

        #endregion

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            lblTimeLeft.Text = "Time Left\n" + Convert.ToString(timeLeft) + " seconds";

            if (timeLeft <= 0)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            PlayingPlayer.Money += MoneyCount;
            lblTimeLeft.Text = "Game Over.";
            btnEndGame.Text = "End Game";
            tmrGameTimer.Stop();
        }
    }
}

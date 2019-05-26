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
    public partial class frmProperty : Form
    {
        public bool isValidSelection { get; set; }
        private Player CurrentPlayer;
        private Property PlayerPosProperty;

        public bool hasPassedGo { get; set; }
        private bool goToJail;

        private int playerMoney, propertyMoney;

        public frmProperty(Player Player, Property Property)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.TopMost = true; // Keeps the form on top of the other forms.
            this.ControlBox = false; // Disables the close button to prevent user from skipping payment or rents.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.

            //this.BackColor = Color.FromArgb(r.Next(1, 149), r.Next(1, 149), r.Next(1, 149));

            CurrentPlayer = Player;
            PlayerPosProperty = Property;
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            LoadPlayer();
            LoadMoneyDetails();
            lblPropertyName.Text = PlayerPosProperty.Name; // Loads the Property Name onto the Form
            LoadPropertyColour(PlayerPosProperty.Color); // Loads the Property Color onto the Form
            LoadPropertyOwnerDetails();

            if (PlayerPosProperty.Cost == -1 || PlayerPosProperty.Rent == -1)
            {
                if (CurrentPlayer.IsInJail)
                {
                    lblPropertyName.Text = "In Jail";

                    lblPropertyOwner.Text = "";
                    lblPropertyInfo.Text = "You are in Jail. You can bail out for $500, or wait until you are released.";
                    btnBuyProperty.Text = "Pay $500";
                    btnEndTurn.Text = "Wait and End Turn";
                    btnPayRent.Visible = false;

                    lblMoneyStats.Text = "Money: $" + playerMoney + "\n- Bail: $500\n--------------\n $" + (playerMoney - 500);
                }
                else if (PlayerPosProperty.Name == "Go")
                {
                    lblPropertyOwner.Text = "";
                    lblPropertyInfo.Text = "You have passed GO! Collect your $500!";

                    btnBuyProperty.Text = "Collect $500";
                    hasPassedGo = true;
                    btnPayRent.Visible = false;

                    lblMoneyStats.Text = "Money: $" + playerMoney + "\n+ Collection: $500\n--------------\n $" + (playerMoney + 500);
                }
                else if (PlayerPosProperty.Name == "Visiting")
                {
                    lblPropertyOwner.Text = "";
                    lblPropertyInfo.Text = "Look at them prisoners. At least you are one of them.";
                    btnBuyProperty.Visible = false;
                    btnPayRent.Visible = false;

                    lblMoneyStats.Text = "";
                }
                else if (PlayerPosProperty.Name == "Go To Jail")
                {
                    lblPropertyOwner.Text = "";
                    lblPropertyInfo.Text = "You have just been arrested! Oh noes!.";
                    btnBuyProperty.Text = "Go To Jail";
                    //btnEndTurn.Enabled = false;
                    btnEndTurn.Visible = false;

                    btnPayRent.Visible = false;
                    goToJail = true;

                    CurrentPlayer.GoneToJail++;

                    lblMoneyStats.Text = "";
                }
                else if (PlayerPosProperty.Name == "Free Parking")
                {
                    lblPropertyOwner.Text = "";
                    lblPropertyInfo.Text = "Looks like you avoided the fine this turn.";
                    btnBuyProperty.Visible = false;
                    btnPayRent.Visible = false;

                    lblMoneyStats.Text = "";
                }
            }
        }

        private void LoadPlayer()
        {
            lblUsername.Text = CurrentPlayer.Name;
            picUserAvatar.Image = CurrentPlayer.Avatar;
        }

        private void LoadMoneyDetails()
        {
            playerMoney = CurrentPlayer.Money;
            if (PlayerPosProperty.Owner == null)
            { // Property is available
                propertyMoney = PlayerPosProperty.Cost;
            }
            else if(CurrentPlayer != PlayerPosProperty.Owner)
            { // Property is owned by other player
                propertyMoney = PlayerPosProperty.Rent;
            }
            else
            { // Property is owned by current player
                propertyMoney = 0;
            }

            lblMoneyStats.Text = "Money: $" + playerMoney + "\n- Cost: $" + propertyMoney + "\n--------------\n $" + (playerMoney - propertyMoney);
        }

        private void LoadPropertyColour(PropertyColour _Colour)
        {
            switch (_Colour)
            {
                case PropertyColour.Blue:
                    lblPropertyName.BackColor = Color.LightBlue;
                    break;
                case PropertyColour.Brown:
                    lblPropertyName.BackColor = Color.SandyBrown;
                    break;
                case PropertyColour.Green:
                    lblPropertyName.BackColor = Color.LightGreen;
                    break;
                case PropertyColour.Grey:
                    lblPropertyName.BackColor = Color.LightGray;
                    break;
                case PropertyColour.Orange:
                    lblPropertyName.BackColor = Color.Orange;
                    break;
                case PropertyColour.Pink:
                    lblPropertyName.BackColor = Color.LightPink;
                    break;
                case PropertyColour.Purple:
                    lblPropertyName.BackColor = Color.MediumPurple;
                    break;
                case PropertyColour.Yellow:
                    lblPropertyName.BackColor = Color.LightYellow;
                    break;
                case PropertyColour.Undefined:
                    lblPropertyName.BackColor = Color.Transparent;
                    break;
                default:
                    break;
            }
        }

        private void LoadPropertyOwnerDetails()
        {
            if (PlayerPosProperty.Owner == null)
            {
                lblPropertyOwner.Text = "This property is currently unowned.";
                lblPropertyInfo.Text = "It costs $" + Convert.ToString(PlayerPosProperty.Cost) + " to purchase this property!\nThe rent of this property is $" + Convert.ToString(PlayerPosProperty.Rent);
                //btnPayRent.Enabled = false;
                btnPayRent.Visible = false;
            }
            else if (PlayerPosProperty.Owner == CurrentPlayer)
            {
                lblPropertyOwner.Text = "This property is currently owned by\n" + PlayerPosProperty.Owner.Name;
                lblPropertyInfo.Text = "You do not need to pay the rent as you own this property.";

                //btnBuyProperty.Enabled = false;
                //btnPayRent.Enabled = false;
                //btnEndTurn.Enabled = true;

                btnBuyProperty.Visible = false;
                btnPayRent.Visible = false;
                btnEndTurn.Visible = true;
            }
            else
            {
                lblPropertyOwner.Text = "This property is currently owned by\n" + PlayerPosProperty.Owner.Name;
                lblPropertyInfo.Text = "You need to pay $" + Convert.ToString(PlayerPosProperty.Rent) + " in rent charges!";
                //btnBuyProperty.Enabled = false;
                //btnEndTurn.Enabled = false;

                btnBuyProperty.Visible = false;
                btnEndTurn.Visible = false;
            }
        }

        #region Form Buttons

        private void btnBuyProperty_Click(object sender, EventArgs e)
        {
            if(hasPassedGo)
            {
                hasPassedGo = false;
                CurrentPlayer.Money = CurrentPlayer.Money + 500;

                lblPropertyInfo.Text = "You have collected your $500. End your turn to continue to move.";
                lblPropertyOwner.Text = "";
                //btnBuyProperty.Enabled = false;

                btnBuyProperty.Visible = false;
            }
            else if(goToJail)
            {
                goToJail = false;
                CurrentPlayer.IsInJail = true;
                frmBoard.boardPositions[CurrentPlayer.Position].Image = null;
                CurrentPlayer.Position = 7;
                frmBoard.boardPositions[CurrentPlayer.Position].Image = CurrentPlayer.Token;

                lblPropertyInfo.Text = "You have been put into Jail. You may bail out next turn or wait it out.";
                lblPropertyOwner.Text = "";
                //btnBuyProperty.Enabled = false;
                btnBuyProperty.Visible = false;
                //btnEndTurn.Enabled = true;
                btnEndTurn.Visible = true;
            }
            else if(CurrentPlayer.IsInJail)
            {
                CurrentPlayer.IsInJail = false;
                lblPropertyInfo.Text = "You have paid $500 to bail out of Jail.";
                lblPropertyOwner.Text = "";
                //btnBuyProperty.Enabled = false;
                btnBuyProperty.Visible = false;
                btnPayRent.Visible = false;
                //btnEndTurn.Enabled = true;
                btnEndTurn.Visible = true;

                CurrentPlayer.Money = CurrentPlayer.Money - 500;
            }
            else
            {
                CurrentPlayer.Money = CurrentPlayer.Money - PlayerPosProperty.Cost;
                PlayerPosProperty.Owner = CurrentPlayer;
                CurrentPlayer.PropertyCount = CurrentPlayer.PropertyCount + 1;

                //btnBuyProperty.Enabled = false;
                btnBuyProperty.Visible = false;
                lblPropertyOwner.Text = "You are now the proud owner of\n" + PlayerPosProperty.Name;

                EventHandler.ChangePBColour(frmBoard.boardPositions[CurrentPlayer.Position], CurrentPlayer.Colour);
            }
        }

        private void btnPayRent_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Money = CurrentPlayer.Money - PlayerPosProperty.Rent;
            PlayerPosProperty.Owner.Money = PlayerPosProperty.Owner.Money + PlayerPosProperty.Rent;

            btnPayRent.Visible = false;
            btnEndTurn.Visible = true;
            //btnPayRent.Enabled = false;
            //btnEndTurn.Enabled = true;
            lblPropertyOwner.Text = "This property is currently owned by\n" + PlayerPosProperty.Owner.Name;
            lblPropertyInfo.Text = "You have paid $" + Convert.ToString(PlayerPosProperty.Rent) + " in rent charges!\nYou may now end your turn.";
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            isValidSelection = true;
            this.Close();
        }

        #endregion


    }
}

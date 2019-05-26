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
    public partial class frmRollDice : Form
    {
        //int[] roll = new int[]{};
        List<int> rolls = new List<int>();
        int count = 0;
        public int roll { get; set; }

        Random r = new Random();

        public frmRollDice()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.
            this.ControlBox = false;
            this.Text = "";
        }

        private void frmRollDice_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 15; i++)
            {
                rolls.Add(r.Next(1, 7));
            }

            tmrRoll.Start();
        }

        private void displayRoll(int rollNo)
        {
            switch (rolls[rollNo])
            {
                case 1:
                    pic_Die.Image = Properties.Resources.dieValue1;
                    break;
                case 2:
                    pic_Die.Image = Properties.Resources.dieValue2;
                    break;
                case 3:
                    pic_Die.Image = Properties.Resources.dieValue3;
                    break;
                case 4:
                    pic_Die.Image = Properties.Resources.dieValue4;
                    break;
                case 5:
                    pic_Die.Image = Properties.Resources.dieValue5;
                    break;
                case 6:
                    pic_Die.Image = Properties.Resources.dieValue6;
                    break;
                default:
                    pic_Die.Image = Properties.Resources.dieValue1;
                    break;
            }
        }

        private void tmrRoll_Tick(object sender, EventArgs e)
        {
            if (count < (rolls.Count-1))
            {
                displayRoll(count);
                count++;
            }
            else
            {
                tmrRoll.Stop();
                tmrClose.Start();
                displayRoll(count);
            }
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            tmrClose.Stop();
            // Waits for a while to show user roll value
            
            roll = rolls[count];
            //MessageBox.Show(roll.ToString());

            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

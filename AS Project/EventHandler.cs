using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Project
{
    public class EventHandler
    {
        public static PictureBox CreatePictureBox(string _Name, Point _Position, Size _Size)
        {
            PictureBox pic = new PictureBox();
            pic.Name = _Name;
            pic.Location = _Position;
            pic.Size = _Size;
            pic.BackColor = Color.Transparent;
            pic.BackgroundImageLayout = ImageLayout.None;
            
            return pic;
        }

        public static void ChangePBColour(PictureBox Picturebox, Color UserColour)
        {
            Picturebox.BackColor = UserColour;
        }

        /*public static void LoadQuestionForm(Player Player)
        {
            using (frmQuestion question = new frmQuestion(Player))
            {
                DialogResult result = question.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (question.answeredQuestion == true)
                    {
                        question.answeredQuestion = false;
                    }
                }
                else
                {
                    MessageBox.Show("Error! The form seems to have went missing...");
                    LoadQuestionForm(Player);
                }
            }
        }

        public static void LoadPropertyForm(Player Player, Property Property)
        {
            using (frmProperty property = new frmProperty(Player, Property))
            {
                DialogResult result = property.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (property.isValidSelection == true)
                    {
                        property.isValidSelection = false;
                    }
                }
                else
                {
                    MessageBox.Show("Error! The form seems to have went missing...");
                    LoadPropertyForm(Player, Property);
                }
            }
        }*/
    }
}

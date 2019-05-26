using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Project
{
    public partial class frmSplash : Form
    {
        List<string> loadingMessages = new List<string>() 
        {
            "Creating and placing thingymabobs.", 
            "Generating Witty Dialog.",
            "Swapping time and space.",
            "Locating monkeys.",
            "Pixelating the pixels.",
            "Did you order a pizza?",
            "Painting rainbows.",
            "Shuffling the clouds.",
            "Breeding the bits."
        };
        Random r = new Random();

        public frmSplash()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "monopolyhighscore.txt"))
            {
                using (FileStream fs = File.Create(AppDomain.CurrentDomain.BaseDirectory + "monopolyhighscore.txt"))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("0");
                    fs.Write(title, 0, title.Length);
                    fs.Close();
                }

                using (StreamWriter sWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "monopolyhighscore.txt")) // write to the file for the username
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sWriter.WriteLine(0);
                        sWriter.WriteLine("User");
                    }
                    sWriter.Close();
                }
            }

            Highscore.HighScore();

            // [REFER] IntervalChange
            //Random r = new Random();
            int customInterval = r.Next(6500, 10000); // Generate Interval between 5 and 10 seconds.
            tmrCountdownToLogin.Interval = customInterval; // Set the Interval of Countdown Timer to random.

            // Start the Main Timers.
            tmrChangeMessage.Start(); // Timer Tick Value: 3000 (3 seconds).
            tmrCountdownToLogin.Start(); // Timer Tick Value: Refer to IntervalChange.
        }

        private void tmrChangeMessage_Tick(object sender, EventArgs e)
        {
            //Random r = new Random();
            int x = r.Next(0, loadingMessages.Count); // Generates a random Integer.
            lblLoadingMessage.Text = loadingMessages[x]; // Using the random Integer generated above, the Loading Message on the form is changed using the defined strings in the messages Array.
            loadingMessages.Remove(loadingMessages[x]);
        }

        private void tmrCountdownToLogin_Tick(object sender, EventArgs e)
        {
            // Stop Timers on the form.
            tmrCountdownToLogin.Stop();
            tmrChangeMessage.Stop();

            // Load frmLogin - Login Form.
            this.Hide();

            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}

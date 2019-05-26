using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Project
{
    public partial class frmQuestion : Form
    {
        public bool answeredQuestion { get; set; }
        public bool outOfQuestions { get; set; }
        public Player PlayerBeingAsked;
        Random random = new Random();
        private int questionNo;

        List<Button> AnswerButtons = new List<Button>();

        public frmQuestion(Player Player)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centers the form to the middle of the screen.
            this.MaximizeBox = false; // Disables the maximize button on top of the form to prevent user from maximizing form.
            this.MinimizeBox = false; // Disables the minimize button on top of the form to prevent user from being able to minimize form.
            this.TopMost = true; // Keeps the form on top of the other forms.
            this.ControlBox = false; // Disables the close button to prevent user from skipping payment or rents.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Changes the form boarder to prevent the user from resizing the form.

            PlayerBeingAsked = Player;

            if (Game.hasQuestionsBeenLoaded == false)
            {
                LoadQuestionsAnswers();
            }
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            lblUsername.Text = PlayerBeingAsked.Name;
            picAvatar.Image = PlayerBeingAsked.Avatar;

            if(Game.Questions.Count >= 1)
            {
                questionNo = random.Next(0, Game.Questions.Count);

                AnswerButtons.Add(btnAnswer1);
                AnswerButtons.Add(btnAnswer2);
                AnswerButtons.Add(btnAnswer3);
                AnswerButtons.Add(btnAnswer4);

                lblQuestion.Text = Game.Questions[questionNo];

                int pos = random.Next(0, AnswerButtons.Count);
                AnswerButtons[pos].Text = Game.CorrectAnswers[questionNo];
                AnswerButtons.RemoveAt(pos);

                pos = random.Next(0, AnswerButtons.Count);
                AnswerButtons[pos].Text = Game.WrongAnswers1[questionNo];
                AnswerButtons.RemoveAt(pos);

                pos = random.Next(0, AnswerButtons.Count);
                AnswerButtons[pos].Text = Game.WrongAnswers2[questionNo];
                AnswerButtons.RemoveAt(pos);

                pos = random.Next(0, AnswerButtons.Count);
                AnswerButtons[pos].Text = Game.WrongAnswers3[questionNo];
                AnswerButtons.RemoveAt(pos);

                foreach (Button findAnswer in pnlAnswerHolder.Controls)
                {
                    findAnswer.Enabled = true;
                }

            }
            else
            {
                //MessageBox.Show("Out of Questions.");
                answeredQuestion = true;
                outOfQuestions = true;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void LoadQuestionsAnswers()
        {
            Game.hasQuestionsBeenLoaded = true;

            var assembly = Assembly.GetExecutingAssembly();
            var QuestionsFile = "AS_Project.Resources.Questions.txt";
            var AnswersFile = "AS_Project.Resources.Answers.txt";
            var WAnswersFile1 = "AS_Project.Resources.WrongAnswers1.txt";
            var WAnswersFile2 = "AS_Project.Resources.WrongAnswers2.txt";
            var WAnswersFile3 = "AS_Project.Resources.WrongAnswers3.txt";

            using (Stream questionsStream = assembly.GetManifestResourceStream(QuestionsFile))
            using (Stream answersStream = assembly.GetManifestResourceStream(AnswersFile))
            using (Stream wAnswersStream1 = assembly.GetManifestResourceStream(WAnswersFile1))
            using (Stream wAnswersStream2 = assembly.GetManifestResourceStream(WAnswersFile2))
            using (Stream wAnswersStream3 = assembly.GetManifestResourceStream(WAnswersFile3))
            {
                using (StreamReader questionsReader = new StreamReader(questionsStream))
                using (StreamReader answersReader = new StreamReader(answersStream))
                using (StreamReader wAnswersReader1 = new StreamReader(wAnswersStream1))
                using (StreamReader wAnswersReader2 = new StreamReader(wAnswersStream2))
                using (StreamReader wAnswersReader3 = new StreamReader(wAnswersStream3))
                {
                    while(questionsReader.Peek() >= 0)
                    {
                        Game.Questions.Add(questionsReader.ReadLine());
                    }

                    while(answersReader.Peek() >= 0)
                    {
                        Game.CorrectAnswers.Add(answersReader.ReadLine());
                    }

                    while(wAnswersReader1.Peek() >= 0)
                    {
                        Game.WrongAnswers1.Add(wAnswersReader1.ReadLine());
                    }

                    while (wAnswersReader2.Peek() >= 0)
                    {
                        Game.WrongAnswers2.Add(wAnswersReader2.ReadLine());
                    }

                    while (wAnswersReader3.Peek() >= 0)
                    {
                        Game.WrongAnswers3.Add(wAnswersReader3.ReadLine());
                    }
                }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn.Text == Game.CorrectAnswers[questionNo])
            {
                if(PlayerBeingAsked.IsInJail)
                {
                    if ((PlayerBeingAsked.JailDuration - 4) == 0)
                    {
                        MessageBox.Show("Correct Answer! You have lived out your time in jail. You may roll on your next turn.");
                    }
                    else
                    {
                        MessageBox.Show("Correct Answer! You need to get " + Convert.ToString(3 - PlayerBeingAsked.JailDuration - 1) + " questions correct to be released, or you can pay the bail amount.");
                    }
                }
                else
                {

                    //MessageBox.Show("You got it correct! You may roll the dice.");
                }
                btn.BackColor = Color.LightGreen;

                answeredQuestion = true;
            }
            else
            {
                //MessageBox.Show("Incorrect Answer! You must skip this roll unfortuantly.");

                btn.BackColor = Color.OrangeRed;

            }

            foreach (Button findAnswer in pnlAnswerHolder.Controls)
            {
                findAnswer.Enabled = false;

                if (findAnswer.Text == Game.CorrectAnswers[questionNo])
                {
                    findAnswer.BackColor = Color.LightGreen;
                }
            }

            tmrViewAnswer.Start();
        }

        private void tmrViewAnswer_Tick(object sender, EventArgs e)
        {
            tmrViewAnswer.Stop();

            Game.Questions.RemoveAt(questionNo);
            Game.CorrectAnswers.RemoveAt(questionNo);
            Game.WrongAnswers1.RemoveAt(questionNo);
            Game.WrongAnswers2.RemoveAt(questionNo);
            Game.WrongAnswers3.RemoveAt(questionNo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
    }
}

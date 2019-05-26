using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

//using ADODB;

namespace AS_Project
{
    public class Game
    {
        public static bool hasQuestionsBeenLoaded = false;

        public static List<string> Questions = new List<string>();
        public static List<string> CorrectAnswers = new List<string>();
        public static List<string> WrongAnswers1 = new List<string>();
        public static List<string> WrongAnswers2 = new List<string>();
        public static List<string> WrongAnswers3 = new List<string>();
        
        public static Property Property1 = new Property("Hacker Way", 60, 20, PropertyColour.Blue);
        public static Property Property2 = new Property("Zuckerberg Lane", 60, 40, PropertyColour.Blue);
        public static Property Property3 = new Property("Berners-Lee Way", 100, 60, PropertyColour.Blue);
        public static Property Property4 = new Property("Linus Lane", 100, 60, PropertyColour.Brown);
        public static Property Property5 = new Property("Gates Street", 120, 80, PropertyColour.Brown);
        public static Property Property6 = new Property("Osborne Gardens", 140, 100, PropertyColour.Brown);
        public static Property Property7 = new Property("Systrom Boulevard", 140, 100, PropertyColour.Green);
        public static Property Property8 = new Property("Chamberlin Lane", 160, 120, PropertyColour.Green);
        public static Property Property9 = new Property("Gosling Way", 180, 140, PropertyColour.Green);
        public static Property Property10 = new Property("Roberts Avenue", 180, 140, PropertyColour.Grey);
        public static Property Property11 = new Property("Miner Gardens", 200, 160, PropertyColour.Grey);
        public static Property Property12 = new Property("Gaben Street", 220, 180, PropertyColour.Grey);
        public static Property Property13 = new Property("Cerf Way", 220, 180, PropertyColour.Orange);
        public static Property Property14 = new Property("Blok Boulevard", 240, 200, PropertyColour.Orange);
        public static Property Property15 = new Property("Jobs Lane", 260, 220, PropertyColour.Orange);
        public static Property Property16 = new Property("Page Gardens", 260, 220, PropertyColour.Pink);
        public static Property Property17 = new Property("Persson Street", 280, 240, PropertyColour.Pink);
        public static Property Property18 = new Property("Hejlsberg Way", 300, 260, PropertyColour.Pink);
        public static Property Property19 = new Property("Wozniak Street", 300, 260, PropertyColour.Purple);
        public static Property Property20 = new Property("Rossum Lane", 320, 280, PropertyColour.Purple);
        public static Property Property21 = new Property("Kildall Boulevard", 350, 300, PropertyColour.Purple);
        public static Property Property22 = new Property("Rubin Street", 350, 300, PropertyColour.Yellow);
        public static Property Property23 = new Property("Brin Gardens", 400, 320, PropertyColour.Yellow);
        public static Property Property24 = new Property("Dorsey Way", 400, 320, PropertyColour.Yellow);

        public static Property Go = new Property("Go", -1, -1, PropertyColour.Undefined);
        public static Property Visiting = new Property("Visiting", -1, -1, PropertyColour.Undefined);
        public static Property FreeParking = new Property("Free Parking", -1, -1, PropertyColour.Undefined);
        public static Property GoToJail = new Property("Go To Jail", -1, -1, PropertyColour.Undefined);

        public static Property[] AllProperties = new Property[28] { 
            Go, Property1, Property2, Property3, Property4, Property5, Property6, // INFO: Board South
            Visiting, Property7, Property8, Property9, Property10, Property11, Property12, // INFO: Board East
            FreeParking, Property13, Property14, Property15, Property16, Property17, Property18, // INFO: Board North
            GoToJail, Property19, Property20, Property21, Property22, Property23, Property24 // INFO: Board West
        };

        public static List<Player> Players = new List<Player>();
        

        public Game()
        {
            //Player P1 = new Player("Player 1");
            //Player P2 = new Player("Player 2");
        }

        public static void AddPlayers(Player P1, Player P2)
        {
            if(Players.Count > 0)
            {
                Players.Clear();
            }
            Players.Add(P1);
            Players.Add(P2);
        }

        /*
        private static OleDbConnection databaseConnection;
        //private static OleDbCommand command;
        //private static OleDbDataReader reader;
        private static OleDbDataAdapter adapter = new OleDbDataAdapter();
        //private static bool attempted = false;
        private static string datasource = Environment.SpecialFolder.ApplicationData + @"\AS Monopoly\AS Project.accdb";
        private static string databaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + datasource + "; Persist Security Info=False;";
        public static void AddPlayersToDB(Player Player1, Player Player2)
        {
            try
            {
                databaseConnection = new OleDbConnection();
                databaseConnection.ConnectionString = databaseConnectionString;
                databaseConnection.Open();

                string query;
                try
                {
                    query = "INSERT INTO accounts ([PlayerName], [QuestionScore], [PropertyScore]) VALUES ('" + Player1.Name + "', '" + Player1.Score + "', '" + Player1.PropertyCount + "')";
                    adapter.InsertCommand = new OleDbCommand(query, databaseConnection);
                    adapter.InsertCommand.ExecuteNonQuery();

                    query = "INSERT INTO accounts ([PlayerName], [QuestionScore], [PropertyScore]) VALUES ('" + Player2.Name + "', '" + Player2.Score + "', '" + Player2.PropertyCount + "')";
                    adapter.InsertCommand = new OleDbCommand(query, databaseConnection);
                    adapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Your account was created successfully.");
                }
                catch (OleDbException exception)
                {
                    MessageBox.Show("There was a problem when creating your account.", "Error!", MessageBoxButtons.OK);
                    MessageBox.Show(exception.ToString());
                }
            }
            catch(OleDbException)
            {
                MessageBox.Show("Unable to find database. Please refer to user guide.", "Error!", MessageBoxButtons.OK);
            }
        }*/
    }
}

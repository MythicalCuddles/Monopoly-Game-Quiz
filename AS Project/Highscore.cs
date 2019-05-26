using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Project
{
    class Highscore
    {
        public static List<Tuple<int, string>> highscore = new List<Tuple<int, string>>();

        public static void HighScore()
        {
            using (StreamReader sReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "monopolyhighscore.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    highscore.Add(Tuple.Create(Convert.ToInt32(sReader.ReadLine()), sReader.ReadLine()));
                }
                sReader.Close(); // closes the document
            }
            highscore.Sort((x, y) => y.Item1.CompareTo(x.Item1));
        }

        public static void newHighScore(string name, int score)
        {
            highscore.Add(Tuple.Create(Convert.ToInt32(score), name));
            highscore.Sort((x, y) => y.Item1.CompareTo(x.Item1));

            using (StreamWriter sWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "monopolyhighscore.txt")) // write to the file for the username
            {
                for (int i = 0; i < highscore.Count(); i++)
                {
                    sWriter.WriteLine(highscore[i].Item1);
                    sWriter.WriteLine(highscore[i].Item2);
                }
                sWriter.Close();
            }
        }
    }
}

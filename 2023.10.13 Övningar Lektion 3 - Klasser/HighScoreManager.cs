using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class HighScoreManager
    {
        string scorePath = @"C:\Users\SOS23\source\repos\2023.10.13 Övningar Lektion 3 - Klasser\2023.10.13 Övningar Lektion 3 - Klasser\bin\Debug\net6.0\scores";
        string scoreFilePath = "scores.txt";
        public List<HighScore> listOfHighScore = new List<HighScore>();


        public void AddHighScore(string name, int points)
        {
            listOfHighScore.Add(new HighScore(name, points));
            using (StreamWriter sw = new StreamWriter(scoreFilePath))
            {
                sw.WriteLine(listOfHighScore[-1].GetCSV());
            }
        }


        //Creates path, directory and so on. 
        public void Filehandling()
        {
            bool directoryExists = Directory.Exists(scorePath);
            if (!directoryExists)
            {
                Directory.CreateDirectory(scorePath);
            }
            bool fileExists = File.Exists(scoreFilePath);
            if (!fileExists)
            {
                File.Create(scoreFilePath);
            }
        }


        public void ViewScores()
        {
            Console.WriteLine("HIGHS SCORES - BEST PLAYERS:\n");
            for (int i = 1; i <= 12; i++)
            {
                try
                {
                    Console.WriteLine($"{i}. {listOfHighScore[i].Name} - {listOfHighScore[i].Score}");
                }
                catch
                {
                    Console.WriteLine($"{i}. No score to preview");

                    if (i == 10)
                    {
                        Console.WriteLine("\nClick to continue...");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }


        public void GetScoresFromFile(List<HighScore> highScores)
        {
            using (StreamReader sr = new StreamReader(scoreFilePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] variables = line.Split('|');
                    string name = variables[0];
                    int score = int.Parse(variables[1]);

                    HighScore highScore = new HighScore(name, score);
                    highScores.Add(highScore);
                    line = sr.ReadLine();
                }
            }
        }


        //This function gets the highScores from the list and writes them into scorePath (?)
        public void SaveScores(List<HighScore> highScores)
        {
            StreamWriter sw = new StreamWriter(scoreFilePath);
            for (int i = 0; i < highScores.Count; i++)
            {
                sw.WriteLine(highScores[i].GetCSV());
                if (i < highScores.Count - 1)
                {
                    sw.WriteLine();
                }
            }
            sw.Close();
        }
    }
}

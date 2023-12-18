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
        string scorePath = "scores.txt";
        public List<HighScore> listOfHighScore = new List<HighScore>();
        public PriorityQueue<HighScore, int> priorityQueue = new PriorityQueue<HighScore, int>();


        //thinking of adding to queue, after highscore is imported. 
        public void AddHighScore(string name, int points)
        {
            priorityQueue.Enqueue(new HighScore(name, points), points);
          //  using (StreamWriter sw = new StreamWriter(scorePath))
          //  {
          //      sw.WriteLine(listOfHighScore[-1].GetCSV());
          //  }
        }


        //Creates path, directory and so on. 
        public void Filehandling()
        {
            bool fileExists = File.Exists(scorePath);
            if (!fileExists)
            {
                File.Create(scorePath);
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


        public void GetScoresFromFile()
        {
            using (StreamReader sr = new StreamReader(scorePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] variables = line.Split('|');
                    string name = variables[0];
                    int score = int.Parse(variables[1]);

                    HighScore highScore = new HighScore(name, score);
                    listOfHighScore.Add(highScore);
                    priorityQueue.Enqueue(highScore, score);
                    line = sr.ReadLine();
                }
            }
        }


        //Here I think I should dequeue the 10 best highscores into scorePath (?)
        public void SaveScores(List<HighScore> highScores)
        {
            StreamWriter sw = new StreamWriter(scorePath);
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(highScores[i].GetCSV());
                if (i == 10)
                {
                    sw.WriteLine();
                }
            }
            sw.Close();
        }
    }
}

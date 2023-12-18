using System;
using System.Collections;
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
        public List<HighScore> listOfHighScore = new List<HighScore>()
        {
            new HighScore("Carl", 56),
            new HighScore("Victor", 25),
            new HighScore("Bea", 25),
            new HighScore("Bosse", 1),
            new HighScore("Garnet", 25),
            new HighScore("Snöret", 33),
            new HighScore("Baljohn", 104),
            new HighScore("Svea", 22),
            new HighScore("Mohammed", 2),
            new HighScore("Sven", 13)
        };

        public PriorityQueue<HighScore, int> priorityQueue = new PriorityQueue<HighScore, int>();

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
                    //   listOfHighScore.Add(highScore);
                    priorityQueue.Enqueue(highScore, score);
                    line = sr.ReadLine();
                }
            }
        }


        //Adds the new score to priorityQueue (To be able to sort the the 10 best results)
        public void AddHighScore(string name, int points)
        {
            //listOfHighScore.Add(new HighScore(name, points));
            priorityQueue.Enqueue(new HighScore(name, points), points);
        }


        //Dequeues the priorityQueue that now contains 11 scores, to only include the ten best in listOfHighscores
        public void DeQueueToListOfHighScores()
        {
            if (priorityQueue.Count == 0) return;
            for (int i = 0; i < 10; i++)
            {
                listOfHighScore[i] = priorityQueue.Dequeue();
            }
        }


        public void ViewScores()
        {
            Console.WriteLine("HIGHS SCORES - BEST PLAYERS:\n");
            for (int i = 0; i <= 10; i++)
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


        //Here I think I should dequeue the 10 best highscores into scorePath (?)
        public void SaveScores(List<HighScore> highScores)
        {
            StreamWriter sw = new StreamWriter(scorePath);
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(listOfHighScore[i].GetCSV());
                if (i == 10)
                {
                    sw.WriteLine();
                }
            }
            sw.Close();
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
    }
}

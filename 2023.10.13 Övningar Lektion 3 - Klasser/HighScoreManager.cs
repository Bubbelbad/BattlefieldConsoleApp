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
        public List<HighScore> listOfHighScore = new List<HighScore>() { };
        public PriorityQueue<HighScore, int> priorityQueue = new PriorityQueue<HighScore, int>();
        string scorePath = "scores.csv";


        //Importing previous scores from CSV file
        public void GetScoresFromFile()
        {
            using (StreamReader sr = new StreamReader(scorePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] variables = line.Split(',');
                    string name = variables[0];
                    int score = int.Parse(variables[1]);

                    HighScore highScore = new HighScore(name, score);
                    listOfHighScore.Add(highScore);
                    priorityQueue.Enqueue(highScore, score);
                    line = sr.ReadLine();
                }
            }
        }


        //Adds the new score to listOfHighScores and priorityQueue (To be able to sort the 10 best results)
        public void AddHighScore(string name, int points)
        {
            listOfHighScore.Add(new HighScore(name, points));
            priorityQueue.Enqueue(new HighScore(name, points), points);
        }


        //Dequeues the priorityQueue that now contains 11 scores, to only include the ten best in listOfHighscores
        public void DeQueueToListOfHighScores()
        {
            if (priorityQueue.Count == 0) return;
            for (int i = 0; i < 9; i++)
            {
                listOfHighScore[i] = priorityQueue.Dequeue();
            }
            SaveScores(listOfHighScore);
        }


        public void ViewScores()
        {
            Console.WriteLine("HIGHS SCORES - BEST PLAYERS:\n");
            for (int i = 0; i <= 9; i++)
            {
                try
                {
                    Console.WriteLine($"{i + 1}. {listOfHighScore[i].Name} - {listOfHighScore[i].Score} moves");
                }
                catch
                {
                    Console.WriteLine($"{i + 1}. No score to preview");

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
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
        }


        //Here I think I should dequeue the 10 best highscores into scorePath (?)
        public void SaveScores(List<HighScore> highScores)
        {
            StreamWriter sw = new StreamWriter(scorePath);
            for (int i = 0; i < 9; i++)
            {
                sw.WriteLine(listOfHighScore[i].GetCSV());
                if (i == 9)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class FileHandler
    {
        string scorePath = "score.txt";

        public void Filehandling()
        {
            string folderPath = "thisFolder";
            if (Directory.Extists)
            {

            }
        }

        public void SaveScores(List<HighScore> highScores)
        {
            StreamWriter sw = new StreamWriter(scorePath);
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

        public List<HighScore> GetScoresFromFile()
        {
            List<HighScore> scores = new List<HighScore>();
            using (StreamReader sr = new StreamReader(scorePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] variables = line.Split(',');

                    line = sr.ReadLine();
                }
            }
            return scores;
        }
        public void HighScore(int score)
        {
            PriorityQueue<string, int> highScoreQueue = new PriorityQueue<string, int>(9);
            string filePath = "folder/highScore.txt";
            string file = "highScore.txt";

            Directory.CreateDirectory(filePath);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            if (File.Exists(filePath))
            {

            }
        }

    }
}

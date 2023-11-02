using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class FileHandler
    {
        string scorePath = "score.txt";

        //Creates paths, directory and so on. 
        public void Filehandling()
        {
            string folderPath = "HighScores";
            string copyPath = "copy.txt";
            Directory.CreateDirectory(folderPath);
            File.Copy(scorePath, copyPath);
            if (Directory.Exists(folderPath))
            {
                string filePath = "thisFolder/file.txt";
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("Hello");
                sw.Close();
            }
            FileInfo fileInfo = new FileInfo(scorePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            string absolutePath = @"C:\Users\SOS23\source\repos\2023.10.13 Övningar Lektion 3 - Klasser\2023.10.13 Övningar Lektion 3 - Klasser\bin\Debug\net6.0";
        }


        //This function gets the highScores from the list and writes them into scorePath (?)
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

        //This function gets the current scores from scorePath and makes them readable for C#?
        public List<HighScore> GetScoresFromFile()
        {
            List<HighScore> highScores = new List<HighScore>();
            using (StreamReader sr = new StreamReader(scorePath))
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
            return highScores;
        }

    }
}

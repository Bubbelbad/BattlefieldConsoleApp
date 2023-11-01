using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class HighScore
    {
        public List<HighScore> scores = new List<HighScore>();
        string Name { get; set; }
        int Score { get; set; }

        public HighScore(string name, int score)
        {
            this.Name = name;
            this.Score = score;
            scores.Add(this);
        }

        public string GetCSV()
        {
            return Name + "," + Score;
        }
    }
}

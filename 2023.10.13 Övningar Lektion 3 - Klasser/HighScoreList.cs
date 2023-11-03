using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class HighScoreList
    {

        public List<HighScore> listOfHighScore = new List<HighScore>();

        public void AddHighScore(string name, int points)
        {
            listOfHighScore.Add(new HighScore(name, points));
        }

    }
}

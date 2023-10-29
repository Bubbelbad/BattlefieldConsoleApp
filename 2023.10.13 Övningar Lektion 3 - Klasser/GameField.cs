using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class GameField
    {

        public GameField()
        {

        }

        string cpuShips =     $" CPU's Skepp:";
        string krigsfartyg =  $"  - Krigsfartyg(5)";
        string ubåt =         $"  - Ubåt(4)";
        string vanligtSkepp = $"  - Vanligt skepp(3)";
        string roddbåt =      $"  - Roddbåt(2)";

        //variables för layer 0:
        string[,,] gameField = new string[12, 12, 2];
        string[] array = new string[] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        string unExplored = "~";
        string miss = " ";
        string hit = " ";
        int nums = 1;

        //Variables for layer 1:
        int X = 0;
        int Y = 1;

        public string[,,] SetGameField()
        {
            
            gameField[0, 11, 0] = cpuShips;
            gameField[1, 11, 0] = krigsfartyg;
            gameField[2, 11, 0] = ubåt;
            gameField[3, 11, 0] = vanligtSkepp;
            gameField[4, 11, 0] = roddbåt;


            for (int col = 0; col < 11; col++)
            {
                gameField[col, 0, 0] = $"[{array[col]}]";
            }
            
            for (int row = 1; row < 11; row++)
            {
                gameField[0, row, 0] = $"[{nums}]";
                nums++;
            }


            for (int col = 1; col < 11; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    gameField[col, row, 0] = $"[{unExplored}]";
                }
            }

            for (int col = 1; col < 11; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    gameField[col, row, 1] = "0";
                }
            }

            return gameField;
        }

        public void AddShips()
        {

        }


            //Använd lager 0 för att displaya saker
            //Använd lager 1 för att räkna om båtarna ligger rätt. 
            //Spelarna får bara köra en get; för att bara kunna se lager 1.
            //GameManager kommer kunna köra set; på lager två 


            //Man kan också använda sig av båtarnas interna koordinater. 
            //Först loopar man igenom ifall någon av båtarna har koordinaten man skjutit. 
            //Sedan loopar man igenom vad utgången i kartan blir. 


    }
}

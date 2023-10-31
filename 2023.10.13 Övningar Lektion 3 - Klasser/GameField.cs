using _2023._10._13_Sänka_Skepp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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
        int nums = 1;



        public string[,,] SetGameField()
        {
            //Adding the ship-overview to the side of view-layer
            gameField[0, 11, 0] = cpuShips;
            gameField[1, 11, 0] = krigsfartyg;
            gameField[2, 11, 0] = ubåt;
            gameField[3, 11, 0] = vanligtSkepp;
            gameField[4, 11, 0] = roddbåt;

            //Setting the navigation-letters in view-Layer
            for (int col = 0; col < 11; col++)
            {
                gameField[col, 0, 0] = $"[{array[col]}]";
            }

            //Setting the navigations numbers in view-Layer
            for (int row = 1; row < 11; row++)
            {
                gameField[0, row, 0] = $"[{nums}]";
                nums++;
            }

            //Setting the unexplored ocean char "~" in view-layer
            for (int col = 1; col < 11; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    gameField[col, row, 0] = $"[{unExplored}]";
                }
            }

            //Setting the empty layer with 0 in game layer
            for (int col = 1; col < 11; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    gameField[col, row, 1] = "0";
                }
            }


            //This is not done! 
            //Need to be worked on, but I am too tired right now. 
            List <Ship> lala = AddShips();
            foreach (Ship ship in lala)
            {
                try
                {
                    for (int i = ship.XCoordinate; i <= ship.XCoordinate + ship.Size; i++)
                    gameField[i, ship.XCoordinate, 1] = "1";
                }
                catch (Exception e)
                {
                    for (int i = ship.XCoordinate; i >= ship.XCoordinate - ship.Size; i--)
                    gameField[ship.XCoordinate, i, 1] = "1";
                }
                catch
                {
                    for (int i = ship.XCoordinate; i <= ship.XCoordinate + ship.Size; i++)
                    gameField[ship.XCoordinate, i, 1] = "1";
                }
            }
            return gameField;
        }

        //Function to add 4 new ships to a list that is used in SetGameField.
        //Might not be accurate, needs testing!
        public List<Ship> AddShips()
        {
            List<Ship> listOfShips = new List<Ship>();

            bool addStatus = false;
            while (!addStatus)
            {
                for (int i = 4;  i >= 1; i--)
                {
                    listOfShips.Add(new Ship("krigs", i));
                }
                addStatus = true;
            }
            return listOfShips;
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

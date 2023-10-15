using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal class GameField
    {

        Ship Ship2 = new Ship("A", 2);
        Ship Ship3 = new Ship("B", 3);
        Ship Ship4 = new Ship("C", 4);
        Ship Ship5 = new Ship("D", 5);

        string[][] gameField = new string[11][];



        public void PrintNewGameField()
        {

            string[][] gameField = new string[11][];

            gameField[0] = new string[] {  "[ ]", "[1]", "[2]", "[3]", "[4]", "[5]", "[6]", "[7]", "[8]", "[9]", "[10]", "  CPU's Skepp:" };
            gameField[1] = new string[] {  "[A]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "   - Krigsfartyg   (5)" };
            gameField[2] = new string[] {  "[B]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "   - Ubåt          (4)"};
            gameField[3] = new string[] {  "[C]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "   - Vanligt skepp (3)" };
            gameField[4] = new string[] {  "[D]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "   - Roddbåt       (2)" };
            gameField[5] = new string[] {  "[E]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };
            gameField[6] = new string[] {  "[F]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };
            gameField[7] = new string[] {  "[G]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };
            gameField[8] = new string[] {  "[H]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };
            gameField[9] = new string[] {  "[I]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };
            gameField[10] = new string[] { "[J]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]", "[~]" };


            for (int row = 0; row < gameField.Length; row++) 
            {
                for (int col = 0; col < gameField[row].Length; col++) 
                {
                    Console.Write(gameField[row][col] + " "); 
                }
                Console.WriteLine();
            }

            CreateNewShips();
        }

        //Why can't I reach gameMap? 
        public void CreateNewShips()
        {
            for (int i = 1; i < gameField.Length; i++);
        }



        public void Fire(int row, int col) //För att välja vilken ruta vi vill bomba. 
        {
            Console.WriteLine("\nVilken ruta vill du bomba? \n");
            Console.Write("Välj in rad (lodräd): ");
            int answer = int.Parse(Console.ReadLine());
            Console.Write("Välj en kolumn (vågrät): ");
            int answer2 = int.Parse(Console.ReadLine());
            bool status = false;

            for (int i= 0; row < gameField.Length; row++) 
            {
                for (int j = 0; col < gameField[row].Length; col++) 
                {
                    if (answer == row && answer2 == col && gameField[row][col] == "[~]")
                    {
                        gameField[row][col] = "  "; //Här uppdaterar vi om det blev en miss. 
                        Console.WriteLine("Du missade, inget skepp här.");
                    }
                    else if (answer == row && answer2 == col && gameField[row][col] == "[X]")
                    {
                        Console.WriteLine("Denna rutan har du redan skjutit på.");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}

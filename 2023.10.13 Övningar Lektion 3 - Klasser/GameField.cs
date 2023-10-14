using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
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



        public bool Fire(int row, int col)
        {
            for (int i= 0; row < gameField.Length; row++) 
            {
                for (int j = 0; col < gameField[row].Length; col++) 
                {
                    Console.Write(gameField[row][col] + " "); 
                }
                Console.WriteLine();
            }
        }

    }
}

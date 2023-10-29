using _2023._10._13_Övningar_Lektion_3___Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal class GameManager
    {
        GameField gameF = new GameField();


        int moveCount = 0;
        string[,,] game = new string[12, 12, 2];

        string[] array = new string[] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        List<string> highScore = new List<string> { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", };


        public GameManager()
        {

        }

        
        public void GameManagerMenu()
        {
            Console.Clear();
            game = gameF.SetGameField();
            bool menuStatus = true;
            while (menuStatus)
            {
                ViewLayer0();
                Aim(game);
                Console.Clear();
            }
        }



        public void Aim(string[,,] game)
        {
            Console.WriteLine("What column would you like to aim at?");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What row would you like aim at?");
            string input2 = Console.ReadLine().ToUpper();
            Fire(input1, input2, game);
        }


        //To fire the given coordinates.
        public void Fire(int input1, string input2, string[,,] game)
        {
            int arrayPossition = Array.IndexOf(array, input2);
            
            if (game[arrayPossition, input1, 1] == "0")
            {
                game[arrayPossition, input1, 0] = "[ ]";
                moveCount++;
                Console.WriteLine(">> This was a miss! ");
                Console.ReadLine();
            }
            else if (game[arrayPossition, input1, 1] == "1")
            {
                game[arrayPossition, input1, 0] = "[X]";
                moveCount++;
                Console.WriteLine(">> You hit one of the enemy ships! ");
                Console.ReadLine();
            }
        }



        public void ViewLayer0()
        {

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"{game[i, j, 0]}".PadRight(1));
                }
                Console.WriteLine();
            }
        }



        //To view the gameLayer where the calculations end up. 
        public void ViewLayer1()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"{game[i, j, 1]}".PadRight(3));
                }
                Console.WriteLine();
            }
        }



        private void GenerateCPUBoats()
        {
            throw new NotImplementedException();
        }



        public void LostGame()
        {
            //När spelet är förlorat blir texten röd.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lost the game mate. ");
        }



        public void SeeHightScore()
        {
            Console.Clear();
            Console.WriteLine("Top ten players: \n");

            Console.WriteLine($"1.{highScore[0]}");
            Console.WriteLine($"2.{highScore[1]}");
            Console.WriteLine($"3.{highScore[2]}");
            Console.WriteLine($"4.{highScore[3]}");
            Console.WriteLine($"5.{highScore[4]}");
            Console.WriteLine($"6.{highScore[5]}");
            Console.WriteLine($"7.{highScore[6]}");
            Console.WriteLine($"8.{highScore[7]}");
            Console.WriteLine($"9.{highScore[8]}");
            Console.WriteLine($"10.{highScore[9]}\n");

            Console.WriteLine("Click to continue...");
            Console.ReadLine();
            //Här kommer jag printa ut en lista med de top 10 bästa highscores.
        }



        public void AddTohighScore()
        {
            //Idé om att använda nått från Collections! Typ en lista på 10 bästa spelare. 
            //Kanske en sortedlist, dictionaory eller tuples som sparas i en lista med 10 platser.
        }

    }
}

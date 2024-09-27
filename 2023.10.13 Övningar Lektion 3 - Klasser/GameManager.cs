using _2023._10._13_Övningar_Lektion_3___Klasser;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal class GameManager
    {

        GameField gameF = new GameField();
        HighScoreManager? highScoreManager = null;
        static int moveCount = 0;

        //The different game fields, two layers - one invisible and one visible.
        string[,,] game = new string[12, 12, 2];

        string[] array = new string[] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        List<string> highScore = new List<string> { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", }; //Vad är det här? 


        public GameManager()
        {

        }


        public void SetFileHandler(HighScoreManager highScoreManager1)
        {
            this.highScoreManager = highScoreManager1;
        }


        public void GameManagerMenu()
        {
            Console.Clear();
            game = gameF.SetGameField();
            bool menuStatus = true;
            while (menuStatus)
            {
                ViewLayer0();
                bool count = Aim(game);
                Console.Clear();
                if (count)
                {
                    moveCount++;
                }
                bool win = IsGameWon();
                if (win)
                {
                    Console.Clear() ;
                    Console.ReadKey();

                    return;
                }
            }
        }


        //To give input for aiming at a specific square and then calling Fire()
        public bool Aim(string[,,] game)
        {
            bool aimStatus = false;
            while (!aimStatus)
            {
                try
                {
                    Console.WriteLine("What column would you like to aim at?");
                    int input1 = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("What row would you like aim at?");
                    string input2 = Console.ReadLine()!.ToUpper();
                    bool success = Fire(input1, input2, game);
                    aimStatus = true;
                    return true;
                }
                catch
                {
                    Console.WriteLine("Please put in two coordinates! From 1-10, then A-J\n");
                    return false;
                }
            }
            return false;
        }


        //To fire the given coordinates from Aim
        public bool Fire(int input1, string input2, string[,,] game)
        {
            int arrayPossition = Array.IndexOf(array, input2);
            
            if (game[arrayPossition, input1, 1] == "0") //In case of miss
            {
                game[arrayPossition, input1, 0] = "[ ]"; //Updating viewLayer
                game[arrayPossition, input1, 1] = "2";
                moveCount++;
                Console.WriteLine(">> This was a miss! ");
                Console.ReadKey();
                return true;
            }
            else if (game[arrayPossition, input1, 1] == "1") //In case of hit
            {
                game[arrayPossition, input1, 0] = "[X]"; //Updating viewLayer
                game[arrayPossition, input1, 1] = "X";
                moveCount++;
                Console.WriteLine(">> You hit one of the enemy ships! ");
                Console.ReadKey();
                return true;
            }
            else if (game[arrayPossition, input1, 1] == "2" || game[arrayPossition, input1, 1] == "X")
            {
                Console.WriteLine(">> You already hit this field! Try again...");
                Console.ReadKey();
                return false;
            }

            return false;
        }


        //To view the users 'game view' layer
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


        //To view the "invisible" gameLayer where the ships, hits, misses and unexplored squares are saved
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


        //This function will be implemented at the end, when CPU also has a gameField and can shoot.
        public void LostGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lost the game mate. ");
        }


        //This function looks if there are any "1" / ships left in the hidden layer. 
        //If no ships/"1" are left, the game is won and we'll save the high score.
        public bool IsGameWon()
        {
            int count = 0;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (game[i, i, 1] == "1")
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You won the game.\n");
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine()!;

                highScoreManager!.AddHighScore(name, moveCount);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

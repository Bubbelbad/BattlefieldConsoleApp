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


        List<string> highScore = new List<string> { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", };
        public GameManager()
        {

        }


        GameField gameF = new GameField();

        public void Menu()
        {
            bool menuStatus = true;
            while (menuStatus)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till sänka skepp!\n\n" +
                              " - Spela nytt spel       [1]\n" +
                              " - Se HighScore          [2]\n" +
                              " - Avsluta               [3]\n");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        NewGame();
                        break;
                    case "2":
                        SeeHightScore();
                        break;
                    case "3":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Vänligen skriv en siffra mellan 1 - 3");
                        break;
                }
            }
        }



        public void NewGame()
        {
            Console.Clear();
            gameF.SetGameField();
            gameF.ViewLayer0();
            Console.ReadLine();
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
        private void SeeHightScore()
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

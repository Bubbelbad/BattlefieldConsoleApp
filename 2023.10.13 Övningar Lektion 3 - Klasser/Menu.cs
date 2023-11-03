using _2023._10._13_Sänka_Skepp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class Menu
    {
        GameManager gameManager = new GameManager();
        FileHandler fileHandler = new FileHandler();
        HighScoreList list = new HighScoreList();


        public void TheMenu()
        {
            fileHandler.Filehandling();
            fileHandler.GetScoresFromFile(list.listOfHighScore);

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
                        gameManager.GameManagerMenu();
                        break;
                    case "2":
                        Console.Clear();
                        fileHandler.ViewScores(list.listOfHighScore);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("THANKS FOR CHECKING OUT THIS PROJECT! :)");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Vänligen skriv en siffra mellan 1 - 3");
                        break;

                }
            }
        }
    }
}

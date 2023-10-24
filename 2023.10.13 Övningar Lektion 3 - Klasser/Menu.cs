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

        public void TheMenu()
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
                        gameManager.GameManagerMenu();
                        break;
                    case "2":
                        gameManager.SeeHightScore();
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
    }
}

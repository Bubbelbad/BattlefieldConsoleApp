using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal class GameManager
    {

        public GameManager()
        {

        }


        GameField gameField = new GameField();

        public void Menu()
        {
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





       



        public void NewGame()
        {
            Console.Clear();
            gameField.PrintNewGameField();
        }

        private void GenerateCPUBoats()
        {
            throw new NotImplementedException();
        }


        private void SeeHightScore()
        {
            throw new NotImplementedException();
        }
        public void ExitGame()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal class JaggedArrayClass
    {

        public void PrintNewGameField()
        {

            int[,,] gameField = new int[11, 11, 2];
            for (int i = 0; i < gameField.GetLength(1); i++)
            {
                for (int j = 0; j < gameField.GetLength(0); j++)
                {
                    Console.Write($"{gameField[i, j, 0]}".PadRight(3));
                }
                Console.WriteLine();
            }
            //Använd lager 0 för att displaya saker
            //Använd lager 1 för att räkna om båtarna ligger rätt. 
            //Spelarna får bara köra en get; för att bara kunna se lager 1.
            //GameManager kommer kunna köra set; på lager två 


            //Man kan också använda sig av båtarnas interna koordinater. 
            //Först klara man 

            //Jag skulle kunna göra en switch case,
            //där i eller två speglar oika symboler för att visa spelplanen. 

            //Kolla på en video om 3d-arrayer och återkom. Gör några övningar till du greppat konceptet!
            //Sen kan du göra en Sänka-skepp med det. 

        }
    }
}

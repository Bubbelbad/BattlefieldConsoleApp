using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Övningar_Lektion_3___Klasser
{
    internal interface IShip
    {
        string Name { get; }
        int YCoordinate { get; }
        int XCoordinate { get; }
        int Size { get; }

        bool ShipAlive { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._13_Sänka_Skepp
{
    internal interface IShip
    {
        string Name { get; }
        int XCoordinate { get; }
        int Size { get; }
        bool ShipAlive { get; }
    }
}

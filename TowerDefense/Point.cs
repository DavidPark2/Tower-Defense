using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo (int x, int y)
        {
            // First Program in smaller chunks and then refactor it like below
            //// int xDiff = X - x;
            //// int yDiff = Y - y;

            //// int XDiffSquared = xDiff * xDiff;
            //// int yDiffSquared = yDiff * yDiff;

            //// return (int)Math.Sqrt(XDiffSquared + yDiffSquared);

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }
    }
}

using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            int area = map.Width * map.Height;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}

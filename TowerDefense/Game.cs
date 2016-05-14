using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            try
            {
                MapLocation mapLocation = new MapLocation(20, 3, map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
                Console.ReadLine();
            }
        }
    }
}

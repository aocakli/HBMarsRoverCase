using System;

namespace HBMarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please write map size (x x)");
                    var mapSize = Console.ReadLine().Split(' ');
                    int maxX = int.Parse(mapSize[0]);
                    int maxY = int.Parse(mapSize[1]);
                    Console.WriteLine("Pleas write start point and direction (2 4 W)");
                    var startPointAndDirection = Console.ReadLine().Split(' ');
                    var startX = int.Parse(startPointAndDirection[0]);
                    var startY = int.Parse(startPointAndDirection[1]);
                    var direction = startPointAndDirection[2];
                    Rover rover = new Rover(startX, startY, (Directions)Enum.Parse(typeof(Directions), direction));
                    Console.WriteLine("Please write move order (LMR)");
                    var moveOrder = Console.ReadLine();
                    rover.startAction(maxX, maxY, moveOrder);
                    rover.sayLocation();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

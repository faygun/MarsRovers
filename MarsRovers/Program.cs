using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert Plateau coordinate");
            var plateauCoordinate = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(plateauCoordinate))
                throw new ArgumentException();

            var width = 0;
            var height = 0;
            var arrayplateauCoordinate = plateauCoordinate.Split(' ');
            if (arrayplateauCoordinate.Length > 1)
            {
                int.TryParse(arrayplateauCoordinate[0], out width);
                int.TryParse(arrayplateauCoordinate[1], out height);
            }

            RoverSet roverSet = new RoverSet(new Plateau(width, height));

            Console.WriteLine("Please insert rover's coordinate and direction");
            var roverCoordinateAndDirection = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(roverCoordinateAndDirection))
                throw new ArgumentException();

            Console.WriteLine("Please insert rover's command");
            var roverCommand = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(roverCommand))
                throw new ArgumentException();

            roverSet.AddRover(roverCoordinateAndDirection, roverCommand); //1 2 W

            Console.WriteLine(string.Format("Rover position and direction : {0} {1} {2}", roverSet[0].XCoordinate, roverSet[0].YCoordinate, roverSet[0].Direction));
            Console.ReadLine();
        }
    }
}

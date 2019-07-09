using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class RoverSet : List<IRover>
    {
        public IPlateau Plateau { get; }
        public RoverSet(IPlateau plateau)
        {
            Plateau = plateau;
        }

        public void AddRover(string positions, string commands)
        {
            this.Add(new Rover(this.Plateau, positions, commands));
        }
    }
}

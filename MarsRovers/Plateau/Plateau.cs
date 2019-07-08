using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Plateau : IPlateau
    {
        public virtual int Width { get; private set; }

        public virtual int Height { get; private set; }

        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Plateau(string areaText)
        {
            var points = Helper.GetPointsByText(areaText);
            Width = points.X;
            Height = points.Y;
        }
    }
}

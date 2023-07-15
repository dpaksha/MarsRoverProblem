using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Pleatue
    {
        public int MinX { get; set; } = 0;
        public int MinY { get; set; } = 0;

        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public Pleatue()
        {
            MinX = 0;
            MinY = 0;
        }

        public Pleatue(int maxX, int maxY)
        {
            MinX = 0;
            MinY = 0;
            MaxX = maxX;
            MaxY = maxY;
        }

    }
}

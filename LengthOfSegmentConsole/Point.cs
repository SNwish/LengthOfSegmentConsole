using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfSegmentConsole
{
    class Point
    {
        private double x1, y1, z1, x2, y2, z2;

        public double CoordinateX1
        { get { return x1; }
        set { x1 = value; }
        }
        public double CoordinateX2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double CoordinateY1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double CoordinateY2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public double CoordinateZ1
        {
            get { return z1; }
            set { z1 = value; }
        }
        public double CoordinateZ2
        {
            get { return z2; }
            set { z2 = value; }
        }
    }
}

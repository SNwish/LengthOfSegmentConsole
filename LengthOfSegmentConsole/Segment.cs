using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfSegmentConsole
{
    class Segment: Point
    {   
        public Segment()
        {   CoordinateX1 = Int32.Parse(ReadLine());
            CoordinateX2 = Int32.Parse(ReadLine());
            CoordinateY1 = Int32.Parse(ReadLine());
            CoordinateY2 = Int32.Parse(ReadLine());
            CoordinateZ1 = Int32.Parse(ReadLine());
            CoordinateZ2 = Int32.Parse(ReadLine());
        }
        public double GetLengthOfSegment()
        {return (Math.Sqrt(Math.Pow(CoordinateX2 - CoordinateX1, 2) + Math.Pow(CoordinateY2 - CoordinateY1, 2) + (Math.Pow(CoordinateZ2 - CoordinateZ1, 2)))); }
}
}

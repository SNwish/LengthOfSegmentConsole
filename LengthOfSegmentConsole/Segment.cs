using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LengthOfSegmentConsole
{
    class Segment: Point
    {
        private string cos;
        private void Change()
        {
            cos = string.Join("", ReadLine().Where(c => char.IsDigit(c)));
            cos = Regex.Replace(cos, @"[^\d]", "");
        }

        public double GetLengthOfSegment()
        {return (Math.Sqrt(Math.Pow(CoordinateX2 - CoordinateX1, 2) + Math.Pow(CoordinateY2 - CoordinateY1, 2) + (Math.Pow(CoordinateZ2 - CoordinateZ1, 2)))); }
}
}

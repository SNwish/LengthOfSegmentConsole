using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfSegmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment length = new Segment();
            try
            { length.CoordinateX1 = Int32.Parse(ReadLine()); }
            catch(Exception e)
            { WriteLine($"Nie podales cyfry"); }
            length.CoordinateX2 = Int32.Parse(ReadLine());
            length.CoordinateY1 = Int32.Parse(ReadLine());
            length.CoordinateY2 = Int32.Parse(ReadLine());
            length.CoordinateZ1 = Int32.Parse(ReadLine());
            length.CoordinateZ2 = Int32.Parse(ReadLine());

            WriteLine($"{length.GetLengthOfSegment()}");
            ReadLine();
        }
    }
}

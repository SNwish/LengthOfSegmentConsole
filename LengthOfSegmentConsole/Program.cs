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
            
            WriteLine($"{length.GetLengthOfSegment()}");
            ReadLine();
        }
    }
}

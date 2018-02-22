using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfSegmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {       // do obczajenia Regex.Replace oraz string.Join ss
                string number = string.Join("", ReadLine().Where(c => char.IsDigit(c)));
                number = Regex.Replace(number, @"[^\d]", "");
           

                Segment length = new Segment();
                
                length.CoordinateX1 = Int32.Parse(number);
                WriteLine($"{length.CoordinateX1} and fuck");
                length.CoordinateX1 = Int32.Parse(ReadLine());
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

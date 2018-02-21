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
            string strX1 = ReadLine();
            var charX1 = strX1.ToCharArray();
            for (int ctr = 0; ctr < charX1.Length; ctr++)
            { Console.WriteLine("   {0}: {1}", ctr, charX1[ctr]);
            String str = new String(charX1);
            WriteLine(charX1);
           // length.CoordinateX1 = Convert.ToInt32(charX1[]);
            //WriteLine(length.CoordinateX1);
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

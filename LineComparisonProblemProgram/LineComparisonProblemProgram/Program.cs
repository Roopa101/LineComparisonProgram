using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemProgram
{
    class Program
    {
        public static void Main(string[] args)
        {

            double x1, y1, x2, y2;
            Console.WriteLine("enter first  number x1");
            x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter second number y1");
            y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter third  number x2");
            x2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter fourth  number y2");
            y2 = Double.Parse(Console.ReadLine());

            Length l = new Length();
            double length = l.calculateLengthOfLine(x1, y1, x2, y2);
            Console.WriteLine("the length of line is" + length);

        }

    }
}
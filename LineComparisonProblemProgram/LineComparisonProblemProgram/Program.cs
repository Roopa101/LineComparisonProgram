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

            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("enter line1 x1 value");
            x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter line1 y1 value");
            y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter line1 x2 value");
            x2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter  line1 y2 value");
            y2 = Double.Parse(Console.ReadLine());

            Length l = new Length();
            double length1 = l.calculateLengthOfLine(x1, y1, x2, y2);
            Console.WriteLine("the length of line1 is" + length1);

            Console.WriteLine("enter line2 x3 value");
            x3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter line2 y3 value");
            y3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter line2 x4 value");
            x4 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter line2 y4 value");
            y4 = Double.Parse(Console.ReadLine());

            double length2 = l.calculateLengthOfLine(x3, y3, x4, y4);
            Console.WriteLine("the length of line2 is" + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Two Lines are Equal ");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }

        }


    }
}
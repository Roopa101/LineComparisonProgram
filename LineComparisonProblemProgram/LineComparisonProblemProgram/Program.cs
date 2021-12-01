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

            //using Equals() method to check the equality of two lines of points

            Console.WriteLine("Check The Euality Of two Points");
            
            Console.WriteLine("X1 and X2 are equal: " + x1.Equals(x2));
            Console.WriteLine("Y1 and Y2 are equal: " + y1.Equals(y2));
            Console.WriteLine("X3 and X4 are eual:  " + x3.Equals(x4));
            Console.WriteLine("Y3 and Y4 are equal: " + y3.Equals(y4));
            Console.WriteLine("X1 and X3 are equal: " + x1.Equals(x3));
            Console.WriteLine("X2 and X4 are equal: " + x2.Equals(x4));
            Console.WriteLine("Y1 and Y3 are equal: " + y1.Equals(y3));
            Console.WriteLine("Y2 and Y4 are equal: " + y2.Equals(y4));
            
            //using Equals() Method and CompareTo() Method  to Check the Lines are equal or not
           
            if (length1.Equals(length2))
            {
                Console.WriteLine("The two lines are equal");
            }
            if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The second line is greater than first line");
            }
            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The first line is greater than second line");
            }
            Console.ReadLine();
        }

    }
}
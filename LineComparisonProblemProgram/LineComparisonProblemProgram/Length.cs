using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemProgram
{
    class Length
    {
        public double calculateLengthOfLine(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
    }
}

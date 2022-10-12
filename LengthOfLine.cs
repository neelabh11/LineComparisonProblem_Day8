using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LengthOfLine
    {
        public void CalculateLength()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double l;

            Console.WriteLine("Enter x1 value : ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1 value : ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2 value : ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2 value : ");
            y2 = Convert.ToDouble(Console.ReadLine());

            l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("The length of the line is : " + l);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineEquality
    {
        public void CheckTwoLines()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double x3 = 0;
            double y3 = 0;
            double x4 = 0;
            double y4 = 0;
            double l;
            double m;

            Console.WriteLine("Enter x1 value : ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1 value : ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2 value : ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2 value : ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x3 value : ");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y3 value : ");
            y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x4 value : ");
            x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y4 value : ");
            y4 = Convert.ToDouble(Console.ReadLine());


            l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            m = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            Console.WriteLine("The length of the line l1 is : " + l);
            Console.WriteLine("The length of the line l2 is : " + m);

            if (l == m)
            {
                Console.WriteLine("Two lines are equal : " + l + " = " + m);
            }
            else
            {
                Console.WriteLine("Two lines are not equal : " + l + " = " + m);
            }

        }
    }
}
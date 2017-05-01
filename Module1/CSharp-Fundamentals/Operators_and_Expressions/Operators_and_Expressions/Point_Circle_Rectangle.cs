using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Point_Circle_Rectangle
    {
        public static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            double x0 = 1;
            double y0 = 1;
            bool isInCircle=(Math.Sqrt((x-x0)*(x-x0)+(y-y0)*(y-y0))<=r);
            bool isInRect = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);
            if(isInCircle)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if(isInRect)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}

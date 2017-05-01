using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Point_in_Circle
    {
        public static void Main()
        {
            float x=float.Parse(Console.ReadLine());
            float y=float.Parse(Console.ReadLine());
            float distance=(float)Math.Sqrt(x*x+y*y);
            if (distance <= 2.0)
            {
                Console.WriteLine("yes " + distance.ToString("f2"));
            }
            else
            {
                Console.WriteLine("no "+distance.ToString("f2"));
            }
        }
    }
}

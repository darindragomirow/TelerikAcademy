using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Trapezoid
    {
        public static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            double area =(a+b) * h/2;
            Console.WriteLine("{0:0.0000000}",area);
        }
    }
}

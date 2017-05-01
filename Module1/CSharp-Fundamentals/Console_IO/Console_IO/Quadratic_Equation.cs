using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO
{
    class Quadratic_Equation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            double Dsqrt = Math.Sqrt(D);
            double x1;
            double x2;
            if (D < 0)
            {
                Console.WriteLine("no real roots"); return;
            }
            else if(D==0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("{0:F2}", x1);
            }
            else if(D>0)
            {
                x1 = (-b - Dsqrt) / (2 * a);
                x2 = (-b + Dsqrt) / (2 * a);
                Console.WriteLine("{0:F2}", x1 < x2 ? x1 : x2);
                Console.WriteLine("{0:F2}", x1 > x2 ? x1 : x2);
                
            }

        }
    }
}

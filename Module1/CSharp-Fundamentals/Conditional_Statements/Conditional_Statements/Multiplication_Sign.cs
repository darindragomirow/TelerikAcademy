using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Multiplication_Sign
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if ((A > 0 && B > 0 && C > 0) || ((A > 0 || B > 0 || C > 0) && ((A < 0 && B < 0) || (B < 0 && C < 0) || (A < 0 && C < 0))))
            {
                Console.WriteLine("+");
            }
            else if ((A < 0 && B < 0 && C < 0) || ((A < 0 || B < 0 || C < 0) && ((A > 0 && B > 0) || (B > 0 && C > 0) || (A > 0 && C > 0))))
            {
                Console.WriteLine("-");
            }
            else if (A == 0 || B == 0 || C == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}

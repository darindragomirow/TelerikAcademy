using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double E = double.Parse(Console.ReadLine());

            if(A>B && A>C && A>D && A>E)
            {
                Console.WriteLine(A);
            }
            else if(B>C && B>D && B>E)
            {
                Console.WriteLine(B);
            }
            else if(C>D && C>E)
            {
                Console.WriteLine(C);
            }
            else if(D>E)
            {
                Console.WriteLine(D);
            }
            else
            {
                Console.WriteLine(E);
            }

        }
    }
}

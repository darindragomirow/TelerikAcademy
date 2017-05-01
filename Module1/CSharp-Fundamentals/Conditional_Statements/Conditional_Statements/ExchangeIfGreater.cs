using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double temp;
            if(A>B)
            {
                temp = A;
                A = B;
                B = temp;
            }
            Console.WriteLine(A+" "+B);
        }
    }
}

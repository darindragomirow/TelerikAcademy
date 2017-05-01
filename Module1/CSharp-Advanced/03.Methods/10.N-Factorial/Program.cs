using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialN(num));
        }
        public static BigInteger FactorialN(BigInteger n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return n * FactorialN(n - 1);
            }
        }
    }
}

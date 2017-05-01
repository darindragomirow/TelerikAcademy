using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Loops
{
    class Catalan
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial1=1;
            BigInteger factorial2=1;
            BigInteger factorial3=1;
            for (int i = 1; i <= 2 * N; i++)
            {
                if (i <= N + 1)
                {
                    factorial2 *= i;
                }
                if (i <= N)
                {
                    factorial3 *= i;
                }
                factorial1 *= i;
            }

            //(2N)!/(N+1)!*N!
            Console.WriteLine(factorial1/(factorial2*factorial3));



        }
    }
}

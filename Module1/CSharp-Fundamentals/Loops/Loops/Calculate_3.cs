using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Loops
{
    class Calculate_3
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint K = uint.Parse(Console.ReadLine());
            BigInteger factorial1=1;
            BigInteger factorial2=1;

            //N! / (K! * (N - K)!)

            for(uint i=N;i>K;i--)
            {
                factorial1 *= i;
            }
            for(uint i=1;i<=(N-K);i++)
            {
                factorial2 *= i;
            }
            Console.WriteLine(factorial1/factorial2);
        }
    }
}

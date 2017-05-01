using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loops
{
    class Calculate_Again
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;


            for(int i=1;i<=N;i++)
            {
                if(i<=K)
                {
                    factorialK *= i;
                }
                factorialN *= i; 
            }
            Console.WriteLine(factorialN/factorialK);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            int factorial = 1;
            double S=1;
            for(int i=1;i<=N;i++)
            {   
                factorial*=i;
                //S = 1 + 1!/x + 2!/x2 + … + N!/xN
                S +=((factorial) / Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}",S);
        }
    }
}

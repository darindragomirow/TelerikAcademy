using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Fibonacci_Numbers
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int sum;
            Console.WriteLine();
            Console.Write("0");
            if(N>1)
            Console.Write(", "+1);
            for (int i = 0; i < N-2; i++)
            {
                sum = first + second;
                Console.Write(", "+sum);
                first = second;
                second = sum;
            }
        }

    }
}

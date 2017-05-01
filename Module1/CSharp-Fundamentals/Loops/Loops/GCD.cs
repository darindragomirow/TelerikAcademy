using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class GCD
    {
        static void Main(string[] args)
        {
            string[] numbers = (Console.ReadLine().Split(' '));
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
   
            int R=1;

            if (A > B)
            {
                while (R != 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }
                Console.WriteLine(A);
            }
            else
            {
                 while (R != 0)
                {
                    R = B % A;
                    B = A;
                    A = R;
                }
                Console.WriteLine(B);
            }
           


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Loops
{
    class Odd_Even
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(' ');
            BigInteger productOdd=1;
            BigInteger productEven=1;

            for(int i=0;i<N;i++)
            {
                if(i%2==0)
                {
                    productEven *= int.Parse(nums[i]);
                }
                else
                {
                    productOdd *= int.Parse(nums[i]);
                }
            }
            if(productOdd==productEven)
            {
                Console.WriteLine("yes "+productEven);
            }
            else
            {
                Console.WriteLine("no "+productEven+" "+productOdd);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Prime_Check
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if(num<0)
            {
                Console.WriteLine("false");
                return;
            }
            
            for(int i=2;i<num;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("false"); return;
                }
            }
            Console.WriteLine("true");
        }
    }
}

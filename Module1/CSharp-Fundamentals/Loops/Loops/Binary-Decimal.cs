using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Loops
{
    class Binary_Decimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            ulong result = 0;
            
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i]== '1')
                {
                    result += (ulong)Math.Pow(2, binary.Length - 1 - i);
                }
            }
            Console.WriteLine(result);
            
        }
    }
}

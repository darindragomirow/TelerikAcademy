using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class BitExchange
    {
        public static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            uint mask1 = (1U << 3) | (1U << 4) | (1U << 5);
            Console.WriteLine(Convert.ToString(mask1,2).PadLeft(32,'0'));

            uint mask2 = (1U << 24) | (1U << 25) | (1U << 26);
            Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(32, '0'));
            
            uint modifiedInput = num & ~mask1 & ~mask2;
            Console.WriteLine(Convert.ToString(modifiedInput, 2).PadLeft(32, '0'));


            mask1 &= num;
            mask1 <<= 21;
            mask2 &= num;
            mask2 >>= 21;
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(mask1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(modifiedInput, 2).PadLeft(32, '0'));

            modifiedInput |= mask1 | mask2;

            Console.WriteLine(modifiedInput);
        }
    }
}

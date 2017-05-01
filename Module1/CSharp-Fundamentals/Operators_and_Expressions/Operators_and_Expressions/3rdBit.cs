using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class _3rdBit
    {
        public static void Main()
        {
            ulong num = ulong.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            byte bit = byte.Parse(Console.ReadLine());
            ulong mask;

            if(bit==0)
            {
                mask = (ulong)~(1 << pos);
                num = num & mask;
                Console.WriteLine(num);
            }
            else if(bit==1)
            {
                mask = (ulong)(1<<pos);
                num = num | mask;
                Console.WriteLine(num);
            }

        }
    }
}

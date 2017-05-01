using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class BitSwap
    {
        public static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint bitP;
            uint bitQ;

            //Console.WriteLine(Convert.ToString(num,2).PadLeft(32,'0'));
            //Console.WriteLine();

            for(int i=0;i<k;i++,p++,q++)
            {
                bitP = (num & (1U << p)) >> p;
                bitQ = (num & (1U << q)) >> q;

                //clear the p-th bit,set it to 0
                num &= ~(1U << p);
                //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                //set the p-th bit to bitQ
                num |= (bitQ << p);
                //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                //clear the q-th bit
                num &= ~(1U << q);
               // Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                //set the q-th bit to bitP
                num |= (bitP << q);
               // Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                
            }
            //Console.WriteLine();
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(num);
        }
    }
}

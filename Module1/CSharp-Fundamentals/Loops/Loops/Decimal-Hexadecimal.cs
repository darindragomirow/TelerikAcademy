using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Decimal_Hexadecimal
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            int[] result = new int[100];
             int i=0;
            for(int value=dec;value>=1;value/=16,i++)
            {
                result[i] = (value % 16);
            }
            


            for(int q=i-1;q>=0;q--)
            {
                if(result[q]>9)
                {
                    switch(result[q])
                    {
                        case 10: Console.Write("A"); break;
                        case 11: Console.Write("B"); break;
                        case 12: Console.Write("C"); break;
                        case 13: Console.Write("D"); break;
                        case 14: Console.Write("E"); break;
                        case 15: Console.Write("F"); break;
                    }
                }
                else
                {
                    Console.Write(result[q]);
                }
               
            }
        }
    }
}

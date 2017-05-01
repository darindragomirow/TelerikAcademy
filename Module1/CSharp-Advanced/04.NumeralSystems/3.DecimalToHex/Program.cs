using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHex
{
    class Program
    {
        const string HexDigits = "0123456789ABCDEF";
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
           
            string result = DecimalToHex(N);
            Console.WriteLine(result);

        }

        public static string DecimalToHex(long num)
        {
            string result = string.Empty;

            while(num!=0)
            {
                int value = (int)num % 16;
                if(value<=9)
                {
                    result = value + result;
                }
                else
                {
                    char letter=(char)( value-10+'A');
                    result = letter + result;
                }
                num /= 16;
            }
           // result.Reverse();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            long result = BinaryToDecimal(N);
            Console.WriteLine(result);
            
        }

        public static long BinaryToDecimal(string num)
        {

            int pow = num.Length - 1;
            int digit;
            long result = 0;
            foreach(char c in num)
            {
                digit = c - '0';
                result += digit *(long) Math.Pow(2, pow);
                pow--;
            }
            return result;


        }
    }
}

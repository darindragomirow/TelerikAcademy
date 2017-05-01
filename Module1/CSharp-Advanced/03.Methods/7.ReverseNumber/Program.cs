using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);

        }
        public static void ReverseNumber(string number)
        {
            for(int i=number.Length-1;i>=0;i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}

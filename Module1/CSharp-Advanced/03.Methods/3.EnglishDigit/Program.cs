using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            DigitToWord(num);

        }

        public static void DigitToWord(int num)
        {
            int lastDigit = (num % 10);
            string[] digits={"zero","one","two","three","four","five","six",
                            "seven","eight","nine"};
            Console.WriteLine(digits[lastDigit]);
        }
    }
}

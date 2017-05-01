using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class FourDigits
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number%10;
            int thirdDigit = (number / 10) % 10;
            int secondDigit = (number / 100) % 10;
            int firstDigit = (number / 1000);
            int sum = firstDigit + secondDigit + thirdDigit + lastDigit;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}",lastDigit,thirdDigit,secondDigit,firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", lastDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}",firstDigit, thirdDigit,secondDigit,lastDigit);
            
        }
    }
}

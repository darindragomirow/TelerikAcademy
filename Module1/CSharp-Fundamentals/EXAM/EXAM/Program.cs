using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int firstDigit=number[0]-'0';
            int secondDigit=number[1]-'0';
            int thirdDigit=number[2]-'0';
            double result;
            if(secondDigit%2==0)
            {
                result = (double)(firstDigit + secondDigit) * thirdDigit;
            }
            else
            {
                result =(double) (firstDigit * secondDigit) / thirdDigit;
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}

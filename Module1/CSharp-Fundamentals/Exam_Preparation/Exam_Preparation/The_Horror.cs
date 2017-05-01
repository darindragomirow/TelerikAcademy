using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class The_Horror
    {
        static void Main(string[] args)
        {
            string  digits = (Console.ReadLine());

            int sum = 0;
            int counter = 0;
            for(int i=0;i<digits.Length;i+=2)
            {
                sum += digits[i]-'0';
                counter++;
            }

            Console.WriteLine("{0} {1}",sum,counter);
            
        }

    }
}

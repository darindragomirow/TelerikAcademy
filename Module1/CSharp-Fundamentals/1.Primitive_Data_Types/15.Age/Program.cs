using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your birhtday:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;
            if((birthday.Month==now.Month && birthday.Day>now.Day) || (birthday.Month>now.Month))
            {
                age--;
            }
            Console.WriteLine("Your age is:{0}",age);
            Console.WriteLine("Your age after 10 years will be:{0}",age+10);
        }
    }
}

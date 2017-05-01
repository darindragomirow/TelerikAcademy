using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Sum(str));

        }

          public static int Sum(string numbers)
        {
            string[] array = numbers.Split(' ');
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                sum += int.Parse(array[i]);
            }
            return sum;
        }
    }
}

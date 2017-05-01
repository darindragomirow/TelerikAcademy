using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int c = int.Parse(line[2]);

            int largestNumber = GetLargestNumber(a, GetLargestNumber(b, c));
            Console.WriteLine(largestNumber);
        }
        public static int GetLargestNumber(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO
{
    class SumOf_N
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for(int i=1;i<=N;i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}

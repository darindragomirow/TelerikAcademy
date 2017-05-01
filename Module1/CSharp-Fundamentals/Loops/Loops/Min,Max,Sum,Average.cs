using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Min_Max_Sum_Average
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            double sum=0;
            double average;
            for(int i=1;i<=N;i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num<min)
                {
                    min = num;
                }
                if(num>max)
                {
                    max = num;
                }
                sum += num;
            }
            Console.WriteLine("min={0:F2}",min);
            Console.WriteLine("max={0:F2}",max);
            Console.WriteLine("sum={0:F2}",sum);
            if(N!=0)
            average = (sum/ N);
            Console.WriteLine("avg={0:F2}",average);
        }
    }
}

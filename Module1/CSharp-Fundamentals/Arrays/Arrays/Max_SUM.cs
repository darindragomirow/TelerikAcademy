using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Max_SUM
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            int currmax = array[0];

            for (int i = 1; i < N; i++)
            {
                currmax = Math.Max(array[i], currmax + array[i]);
                if (currmax > max)
                    max = currmax;
            }
            Console.WriteLine(max);
        }
    }
}

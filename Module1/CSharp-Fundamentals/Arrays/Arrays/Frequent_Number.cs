using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Frequent_Number
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i <N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int count=1;
            int maxCount =1;
            int number=0;
            for (int j= 0; j < N; j++)
            {
                count = 1;
                for (int i =j+1; i < N; i++)
                {
                   if(array[j]==array[i])
                   {
                       count++;
                   }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    number = array[j];
                }
            }
            Console.WriteLine(number+"("+maxCount+" times)");

        }
    }
}

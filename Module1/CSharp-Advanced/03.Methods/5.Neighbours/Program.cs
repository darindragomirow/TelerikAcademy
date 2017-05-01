using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            Console.WriteLine(GetLargerThanNeighbours(array));

        }

        public static int GetLargerThanNeighbours(int[] array)
        {
            int counter = 0;
            for(int i=1;i<array.Length-1;i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    counter++;
            }
            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FirstLarger
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
            int index=-1;
            for(int i=1;i<array.Length-1;i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    return index = i;
            }
            return index;
        }
    }
}

        
    


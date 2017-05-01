using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers=new int[N];
            for(int i=0;i<N;i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            SortArray(numbers);


        }
        public static int MaxElement(int[] array,int index)
        {
            int maxElement = array[index];
            int temp;
            for(int i=index;i<array.Length;i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }

            }
            return maxElement;
        }

        public static void SortArray(int[] array)
        {
            int[] reversed = new int[array.Length];
            for(int i=0,j=reversed.Length-1;i<array.Length;i++,j--)
            {
                reversed[j] = MaxElement(array, i);
            }

            for(int i=0;i<reversed.Length;i++)
            {
                if(i==0)
                {
                    Console.Write(reversed[i]);
                }
                else
                Console.Write(" "+reversed[i]);
            }

        }
    }
}

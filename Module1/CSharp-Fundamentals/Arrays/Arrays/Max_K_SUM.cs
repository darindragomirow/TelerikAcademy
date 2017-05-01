using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Max_K_SUM
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] maxElements = new int[K];
            int max=int.MinValue;
            int indexOfMax=0;
            //Searching the max element and add it to the array
            for (int j = 0; j < K; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        indexOfMax = i;
                    }
                        
                }
                //Delete current max to search for the others
                array[indexOfMax] = int.MinValue;
                //Add the max to the array
                maxElements[j] = max;
                max = int.MinValue;
            }
            int maxSum=0;
            for(int i=0;i<K;i++)
            {
                maxSum+=maxElements[i];
            }
            Console.WriteLine(maxSum);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Selection_Sort
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int minvalue;
            int temp;
            for(int j=0;j<N-1;j++)
            {
                minvalue = j;
                
                for(int i=j+1;i<N;i++)
                {
                    if(array[i]<array[minvalue])
                    {
                        minvalue = i;
                    }
                }
                if(minvalue!=j)
                {
                    temp = array[j];
                    array[j] = array[minvalue];
                    array[minvalue] = temp;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

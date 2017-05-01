using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Quick_Sort
    {
        public static void QuickSort(int[] array,int left,int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];
            int temp;
            while(i<=j)
            {
                while(array[i]<pivot)
                {
                    i++;
                }
                while(array[j]>pivot)
                {
                    j--;
                }

                if(i<=j)
                {
                    //Swapping
                    temp = array[i];
                    array[i]=array[j];
                    array[j]=temp;
                    i++;
                    j--;
                }
                if (left < j)
                {
                    QuickSort(array, left, j);
                }
                if(i<right)
                {
                    QuickSort(array, i, right);
                }
            }

        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //
            QuickSort(array, 0, array.Length - 1);
            //
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}

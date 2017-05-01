using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Binary_Search
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());

            int min = 0;
            int max = array.Length - 1;
            int mid;
            while( min <= max )
            {
                mid = (min + max) / 2;
                if(array[mid]==X)
                {
                    Console.WriteLine(mid); return;
                }else if(array[mid]>X)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            Console.WriteLine(-1);
        }
    }
}

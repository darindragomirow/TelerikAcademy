using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Compare_Arrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1=new int[N];
            int[] array2 = new int[N];
            
            for(int i=0;i<N;i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            int flag=1;
            for (int i = 0; i < N; i++)
            {
                if( array1[i] != array2[i] )
                {
                    flag = 0; break;
                }
            }
            Console.WriteLine(flag !=0 ? "Equal":"Not Equal");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Maximal_Sequence
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSequence = 1;
            int counter = 1;
            for(int i=0;i<N-1;i++)
            {
                if(array[i]==array[i+1])
                {
                    if(++counter>maxSequence)
                    {
                        maxSequence = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}

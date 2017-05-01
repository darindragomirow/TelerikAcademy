using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Appearance
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int X = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for(int i=0;i<N;i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            Counter(array, X);

        }

        public static void Counter(int[] array,int X)
        {
            int counter=0;
            for(int i=0;i<array.Length;i++)
            {
                if (X == array[i])
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}

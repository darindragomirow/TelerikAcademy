using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[5];
            for(int i=0;i<5;i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            Calculation(numbers);

        }

        public static void Calculation(params int[] array)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            double average;
            int sum=0;
            int product = 1;

            for(int i=0;i<array.Length;i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if(array[i]>max)
                {
                    max = array[i];
                }
                sum += array[i];
                product *= array[i];
            }

            average = array.Average();

            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine("{0:F2}",average);
            Console.WriteLine(array.Sum());
            Console.WriteLine(product);




            
        }
    }
}

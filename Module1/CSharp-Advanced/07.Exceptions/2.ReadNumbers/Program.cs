using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lastNumber = 0;
                int[] numbers=new int[10];
                for (int i = 0; i < numbers.Length;i++ )
                {
                    numbers[i] = ReadNumbers(lastNumber, 100);
                    lastNumber = numbers[i];
                }
                Console.WriteLine("1 < "+string.Join(" < ",numbers)+" < 100");
                   
            }
            catch(FormatException)
            {
                Console.WriteLine("Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        public static int ReadNumbers(int start,int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new FormatException();
            }
            return number;
        }
    }
}

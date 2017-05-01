using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.NumeralSystems
{
    class DecimalToBinary
    {
        const string HexValues = "0123456789ABCDEF";
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            List<long> binaryNumber = FromDecimalToBinary(decimalNumber);

            foreach (var item in binaryNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static List<long> FromDecimalToBinary(long number)
        {
            List<long> binary = new List<long>();

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                    binary.Add(0);
                }
                else
                {
                    number /= 2;
                    binary.Add(1);
                }
            }
            binary.Reverse();

            return binary;
        }
    }
}

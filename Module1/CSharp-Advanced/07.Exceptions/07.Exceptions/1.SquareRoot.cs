using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0) throw new ArithmeticException();
                double result = Math.Sqrt(number);
                Console.WriteLine("{0:F3}",result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
                
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("Invalid number");

            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            


        }
    }
}

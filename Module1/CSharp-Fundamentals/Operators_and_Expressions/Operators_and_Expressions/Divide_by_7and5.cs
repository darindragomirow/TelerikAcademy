using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Divide_by_7and5
    {
        public static void Main(string...args)
        {
            int number = int.Parse(Console.ReadLine());
            if((number%7==0)&&(number%5==0))
            {
                Console.WriteLine("true "+number);
            }
            else
            {
                Console.WriteLine("false"+number);
            }
        }
    }
}

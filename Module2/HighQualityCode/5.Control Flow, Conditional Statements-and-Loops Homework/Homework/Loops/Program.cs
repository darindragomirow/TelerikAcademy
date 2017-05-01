using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFound = true;
            for (int i = 0; i < 100;)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                    } 
                }
                else
                {
                    Console.WriteLine(array[i]); 
                }
                i++;
            }
            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

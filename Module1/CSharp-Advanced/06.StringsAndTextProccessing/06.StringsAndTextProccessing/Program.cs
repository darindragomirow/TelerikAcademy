using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndTextProccessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(StringReverse(str));

        }
        public static string StringReverse(string str)
        {
            string reversed = string.Empty;
            for(int i=str.Length-1;i>=0;i--)
            {
                reversed = reversed + str[i];
            }
            return reversed;

        }
        
    }
}

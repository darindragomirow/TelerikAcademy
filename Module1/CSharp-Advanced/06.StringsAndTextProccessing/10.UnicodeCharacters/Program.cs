using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach(char c in text)
            {
                result.Append(charToUnicode(c));
            }

            Console.WriteLine(result);
            
           
        }
        public static string charToUnicode(char c)
        {
            return "\\u" +((int)c).ToString("X4");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            pattern = pattern.ToLower();
            string text = Console.ReadLine();
            text = text.ToLower();
            int count = NumberOfOccurences(pattern, text);
            Console.WriteLine(count);
        }

        public static int NumberOfOccurences(string str,string text)
        {
            int index = text.IndexOf(str);
            int count = 0;
            while(index!=-1)
            {
                count++;
                index = text.IndexOf(str, index + 1);
            }
            return count;
        }
    }
}

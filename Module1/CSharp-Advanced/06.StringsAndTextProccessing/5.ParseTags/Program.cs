using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int start = str.IndexOf("<upcase>");
            int end = str.IndexOf("</upcase>");
           while (start != -1 && end != -1)
            {
                string replace = str.Substring(start + 8, end - (start+8));
                str = str.Replace(replace, replace.ToUpper());
                str = str.Remove(start, 8);
                str = str.Remove(end - 8, 9);
                 start = str.IndexOf("<upcase>");
                 end = str.IndexOf("</upcase>");

            }
            Console.WriteLine(str);

            
           

        }
    }
}

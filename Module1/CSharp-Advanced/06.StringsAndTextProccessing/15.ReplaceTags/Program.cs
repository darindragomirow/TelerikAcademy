using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string readText = Console.ReadLine();
            string text;
            string url;
            int startIndex=0;
            int endIndex=0;
            string line=string.Empty;
            int firstQuoteIndex;
            int secondQuoteIndex;
            int textStartIndex;
            int textEndIndex;

            while (startIndex != -1 && endIndex != -1)
            {
                startIndex = readText.IndexOf("<a");
                endIndex = readText.IndexOf("a>") + 1;
                if (startIndex < 0 || endIndex < 0) break;
                line = readText.Substring(startIndex, endIndex - startIndex + 1);

              //  Console.WriteLine(line);

                firstQuoteIndex = line.IndexOf('"');
                secondQuoteIndex = line.IndexOf('"' + ">");
                url = line.Substring(firstQuoteIndex + 1, secondQuoteIndex - firstQuoteIndex - 1);
               // Console.WriteLine(url);

                textStartIndex = line.IndexOf('>');
                textEndIndex = line.IndexOf("</");
                text = line.Substring(textStartIndex + 1, textEndIndex - textStartIndex - 1);
               // Console.WriteLine(text);

                string replaced = "[" + text + "]" + "(" + url + ")";
                readText = readText.Replace(line, replaced);
            }
            Console.WriteLine(readText);
        }
    }
}

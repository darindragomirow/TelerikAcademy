using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            foreach(string sentence in sentences)
            {
                string[] words = sentence.Split(' ');
                foreach(string w in words)
                {
                    if(w==word)
                        Console.Write(sentence+'.');
                }
            }
            
        }
    }
}

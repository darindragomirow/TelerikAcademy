using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Index_Of_Letters
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            for(int i=97,j=0;i<123;i++,j++)
            {
                letters[j] =(char)i;
            }
           
            //Reading a word from the console
            string word = Console.ReadLine();
            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < 26; i++)
                {
                    if(word[j]==letters[i])
                    {
                        Console.WriteLine(i); break;
                    }
                }
            }

        }
    }
}

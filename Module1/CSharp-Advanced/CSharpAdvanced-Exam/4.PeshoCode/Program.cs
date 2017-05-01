using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PeshoCode
{
    class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            string[] lines = new string[N];
            for(int i=0;i<N;i++)
            {
                lines[i] = Console.ReadLine();
            }

            int indexOfDot = 0;
            int indexOfQuestion = 0;
            int indexOfWord = 0;
            string substring = String.Empty ;
            for(int i=0;i<lines.Length;i++)
            {
                indexOfWord = lines[i].IndexOf(word);
                indexOfDot = lines[i].IndexOf('.');
                indexOfQuestion = lines[i].IndexOf('?');
                if (indexOfWord != -1)
                {
                    if (indexOfDot != -1)
                    {
                        substring = lines[i].Substring(0, indexOfWord);

                    }
                    else if (indexOfQuestion != -1)
                    {
                        int start = indexOfWord + word.Length;
                        if(indexOfQuestion>indexOfWord)
                        {
                        substring = lines[i].Substring(start, indexOfQuestion - start);
                        }
                        else
                        {
                            substring = lines[i].Substring(start, lines[i].Length - start);
                            indexOfQuestion = lines[i + 1].IndexOf('?');
                            if (indexOfQuestion != -1)
                            {
                                substring += lines[i+1].Substring(0, indexOfQuestion);
                            }

                        }
                    }
                    else
                    {
                        int lastIndexOfDot = lines[i - 1].IndexOf('.') + 1;
                        indexOfDot = lines[i + 1].IndexOf('.');
                        indexOfQuestion = lines[i + 1].IndexOf('?');
                        if (indexOfDot != -1)
                        {
                            substring = lines[i - 1].Substring(lastIndexOfDot, lines[i - 1].Length - lastIndexOfDot);
                            substring += lines[i].Substring(0, indexOfWord);

                        }
                        else
                        {
                            int start = indexOfWord + word.Length;
                            substring = lines[i].Substring(start, lines[i].Length - start);
                            substring += lines[i + 1].Substring(0, indexOfQuestion);

                        }
                    }
                }
                
            }

            long result = CalculateCodes(substring);
            Console.WriteLine(result);


        }

        public static long CalculateCodes(string text)
        {
            text = text.ToUpper();
            long sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    sum += 0;
                }
                else
                sum += (int)text[i];
            }
            return sum;
        }
    }
}

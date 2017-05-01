using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PeshoCodeNew
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string word = Console.ReadLine();
                int N = int.Parse(Console.ReadLine());
                string[] lines = new string[N];
                for (int i = 0; i < N; i++)
                {
                    lines[i] = Console.ReadLine();

                }
                string substring = String.Empty;
                int indexOfDot = 0;
                int indexOfQuestion = 0;
                int indexOfWord = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    indexOfWord = lines[i].IndexOf(word);
                    if (indexOfWord != -1)
                    {
                        indexOfDot = lines[i].IndexOf('.');
                        indexOfQuestion = lines[i].IndexOf('?');

                        if (indexOfDot != -1)
                        {
                            substring = lines[i].Substring(0, indexOfWord);
                        }
                        else if (indexOfDot == -1 && indexOfQuestion==-1)
                        {
                            if (i < lines.Length)
                            {
                                int lastIndexOfDot = lines[i - 1].IndexOf('.') + 1;

                                indexOfDot = (lines[i + 1].IndexOf('.'));
                                if (indexOfDot != -1)
                                {
                                    substring = lines[i - 1].Substring(lastIndexOfDot, lines[i - 1].Length - lastIndexOfDot);
                                    substring += lines[i].Substring(0, indexOfWord);
                                }
                            }
                        }
                        if (indexOfQuestion != -1)
                        {
                            int start = indexOfWord + word.Length;
                            substring = lines[i].Substring(start, indexOfQuestion - start);
                        }
                        else
                        {
                            if (i < lines.Length)
                            {
                                if ((indexOfQuestion = lines[i + 1].IndexOf('?')) != -1)
                                {
                                    int start = indexOfWord + word.Length;
                                    substring = lines[i].Substring(start, lines[i].Length - start);
                                    substring += lines[i + 1].Substring(0, indexOfQuestion);
                                }
                            }
                        }

                    }




                }



                int result = CalculateCodes(substring);
                Console.WriteLine(result);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static int CalculateCodes(string text)
        {
            text = text.ToUpper();
            int sum = 0;
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

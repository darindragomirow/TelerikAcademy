using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            if(isCorrect(expression))
                Console.WriteLine("Correct");
            else Console.WriteLine("Incorrect");

        }

        public static bool isCorrect(string str)
        {
            int openBrackets = 0;
            int closeBrackets = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i].Equals(')'))
                {
                    closeBrackets++;
                }
                else if(str[i].Equals('('))
                {
                    openBrackets++;
                }

            }
            if (closeBrackets == openBrackets)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            char currentLetter = line[0];
            Console.Write(currentLetter);
            for(int i=1;i<line.Length;i++)
            {
                if(line[i] != currentLetter)
                {
                    currentLetter = line[i];
                    Console.Write(currentLetter);
                }
            }

        }
    }
}

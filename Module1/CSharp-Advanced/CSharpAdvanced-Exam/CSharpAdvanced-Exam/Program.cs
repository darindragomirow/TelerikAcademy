using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSharpAdvanced_Exam
{
    class Program
    {
        static string[] digits={ "ocaml","haskell","scala","f#","lisp","rust","ml","clojure",
	            "erlang","standardml","racket","elm","mercury","commonlisp","scheme","curry" };

        static void Main(string[] args)
        {
            char[] separator = { ',' };
            string[] readDigits = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            string firstDigit = readDigits[0];
            Console.WriteLine(firstDigit);
            firstDigit = firstDigit.Replace("ocaml", "0 ").Replace("haskell", "1 ").Replace("scala", "2 ")
                .Replace("f#", "3 ").Replace("lisp", "4 ");
            Console.WriteLine(firstDigit);
            string[] array=firstDigit.Split(' ');
            int[] sum = new int[15];
            for(int i=0;i<array.Length;i++)
            {
                sum[i]=int.Parse(array[i]);
            }
            



        }    
    }
}

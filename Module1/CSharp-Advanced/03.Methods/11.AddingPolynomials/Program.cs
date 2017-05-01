using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            int[] firstPol = new int[N];
            int[] secondPol = new int[N];
            Init(firstPol, line1);
            Init(secondPol, line2);
            CalculatePolynomials(firstPol, secondPol);

            
        }

        public static void Init(int[] array,string[] line)
        {
            for(int i=0;i<array.Length;i++)
            {
                array[i] =int.Parse( line[i]);
            }
        }
        public static void CalculatePolynomials(int[] pol1,int[] pol2)
        {
            for(int i=0;i<pol1.Length;i++)
            {
                if(i==0)
                Console.Write(pol1[i]+pol2[i]);
                else
                {
                    Console.Write(" " + (pol1[i] + pol2[i]));
                }
            }
            
        }
    }
}

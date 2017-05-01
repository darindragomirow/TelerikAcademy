using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Sorting
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine()); 

            if(A>B && A>C)
            {
                Console.WriteLine(A+" ");
                if (B > C)
                {
                    Console.Write(B+" ");
                    Console.Write(C);
                }
                else
                {
                    Console.Write(C+" ");
                    Console.Write(B);
                }

            }
            else if(B>C)
            {
                Console.Write(B);
                if (A > C)
                {
                    Console.Write(A+" ");
                    Console.Write(C);
                }
                else
                {
                    Console.Write(C+" ");
                    Console.Write(A);
                }
            }
            else
            {
                Console.Write(C+" ");
                if(A>B)
                {
                    Console.Write(A+" ");
                    Console.Write(B);
                }
                else
                {
                    Console.Write(B+" ");
                    Console.Write(A);
                }
            }
        }
    }
}

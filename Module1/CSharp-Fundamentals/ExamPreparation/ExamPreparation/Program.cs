using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix=new int[3,3];
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    Console.WriteLine("matrix[{0},{1}]=",i,j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
               
            }
            //Printing
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

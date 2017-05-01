using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximal_SUm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N =int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[,] matrix=new int[N,M];
            int sum = 0;
            int maxSum = int.MinValue;
            for(int i=0;i<N;i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for(int j=0;j<M;j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }

            }

            for(int row=0;row<N-2;row++)
            {
                for(int col=0;col<M-2;col++)
                {
                    sum = matrix[row,col] + matrix[row,col + 1] + matrix[row,col + 2]
                          + matrix[row + 1,col] + matrix[row + 1,col + 1] + matrix[row + 1,col + 2]
                          + matrix[row + 2,col] + matrix[row + 2,col + 1] + matrix[row + 2,col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
                
                
            }
            Console.WriteLine(maxSum);

        }
    }
}

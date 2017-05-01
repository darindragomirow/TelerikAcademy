using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LargestAreaInMatrix
{
    class Program
    {
        
        static int N;
        static int M;
        static int[,] matrix;
        static bool[,] visitedElements;
        static int counter=0;
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            N = int.Parse(input[0]);
            M = int.Parse(input[1]);
            visitedElements = new bool[N, M];
            matrix = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }

            }


            //Calculate
            MatrixCalculation();
            //Print
            Console.WriteLine(counter);

           


            
        }
        static void MatrixCalculation()
        {
            int currentCounter = 0;
            int counter = 0;
            int element;

            for(int row=0;row<N;row++)
            {
                for(int col=0;col<M;col++)
                {
                    element = matrix[row, col];
                    DFS(element, row, col, ref currentCounter);
                    counter = MaxCounter(ref currentCounter);
                }
            }
                      
        }

        static void DFS(int element,int row,int col,ref int currentCounter)
        {
            if(row<0 || col<0 || row>=N || col>=M || visitedElements[row,col]==true)
            {
                return;
            }
            if(matrix[row,col]==element)
            {
                currentCounter++;
                visitedElements[row, col] = true;

                DFS(element, row, col + 1, ref currentCounter);//right
                DFS(element, row, col - 1, ref currentCounter);//left
                DFS(element, row - 1, col, ref currentCounter);//up
                DFS(element, row + 1, col, ref currentCounter);//down
            }
        }
        static int MaxCounter(ref int currentCounter)
        {
            if (currentCounter > counter)
            {
                counter = currentCounter;
            }
            currentCounter = 0;
            return counter;
        }
    }
}

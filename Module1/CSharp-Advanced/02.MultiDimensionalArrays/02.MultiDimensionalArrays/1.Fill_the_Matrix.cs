using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int rows = N;
            int cols = N;
            int[,] matrix=new int[rows,cols];
            char choice =char.Parse(Console.ReadLine());
            int counter=1;
            try
            {
                switch (choice)
                {
                    case 'a':
                        for (int col = 0; col < cols; col++)
                        {
                            for (int row = 0; row < rows; row++, counter++)
                            {
                                matrix[row, col] = counter;

                            }
                        }

                        break;
                    case 'b':
                        for (int col = 0; col < cols; col++)
                        {
                            if ((col + 1) % 2 != 0)
                            {
                                for (int row = 0; row < rows; row++, counter++)
                                {
                                    matrix[row, col] = counter;
                                }
                            }
                            else
                            {
                                for (int row = rows - 1; row >= 0; row--, counter++)
                                {
                                    matrix[row, col] = counter;
                                }
                            }
                        }
                        break;
                    case 'c':


                        for (int c = 0; c < cols; c++)
                        {
                            for (int i = 0, row = rows - 1 - c; i <= c; i++, row++)
                            {
                                matrix[row, i] = counter++;
                            }
                        }

                        for (int c = 1; c < cols; c++)
                        {
                            for (int i = c, row = 0; i < cols; i++, row++)
                            {
                                matrix[row, i] = counter++;
                            }
                        }
                        break;
                    case 'd':
                        matrix = SpiralMatrix(rows, cols);
                        break;
                       
                    default: Console.WriteLine("INVALID INPUT!");
                        break;
                }


                {
                    
                }

                for (int j = 0; j < rows; j++)
                {
                    for (int i = 0; i < cols; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("{0,-3}", matrix[j, i]);
                        }
                        else
                            Console.Write(" {0,-3}", matrix[j, i]);
                    }
                    Console.WriteLine();
                }
            }
             catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            

        }

        public static int[,]SpiralMatrix(int rows,int cols)
    {
        
        int[,] matrix = new int[rows,cols];
        int N = cols;
        int length = N;
        int innerSquares = (int)Math.Ceiling(N / 2.0);
        int counter = 1;

        for (int i = 0; i < innerSquares; i++)
        {
            //Fill top...
            for (int j = 0; j < N; j++)
            {
                matrix[(i + j), i] = counter++;
            }

            //Fill right...
            for (int j = 1; j < N; j++)
            {
                matrix[(N - 1 + i), j + i] = counter++;
            }
            //Fill bottom
            for (int j = N - 2; j > 0; j--)
            {
                matrix[(j + i), (N - 1 + i)] = counter++;
            }
            //Fill left
            for (int j = N - 1; j > 0; j--)
            {
                matrix[i, (j + i)] = counter++;
            }
            N = N - 2;
        }
        return matrix;
    }
    

    }
}

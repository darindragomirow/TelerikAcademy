using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sequence_in_Matrix
{
    class Sequence
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[,] matrix = new int[N, M];
            int seq = 1;
            int maxSeq = 1;
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }

            }
            //Search horizontal
            for(int row=0;row<matrix.GetLength(0);row++)
            {
                for(int col=0;col<matrix.GetLength(1)-1;col++)
                {
                    if(matrix[row,col]==matrix[row,col+1])
                    {
                        seq++;
                        
                    }
                    else
                    {
                        if (seq > maxSeq)
                        maxSeq = seq;
                        seq = 1;
                    }
                }
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                }
                seq = 1;
            }

            //Search vertically
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row+1, col])
                    {
                        seq++;

                    }
                    else
                    {
                        if (seq > maxSeq)
                            maxSeq = seq;
                        seq = 1;
                    }
                }
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                }
                seq = 1;
            }

            //diagonal '\'
            //first part
            for(int col=0;col<matrix.GetLength(1);col++)
            {
                for(int checkRow=0,checkCol=col;checkRow<matrix.GetLength(0)-1&& checkCol<matrix.GetLength(1)-1;checkRow++,checkCol++)
                {
                    if(matrix[checkRow,checkCol]==matrix[checkRow+1,checkCol+1])
                    {
                        seq++;
                    }
                    else
                    {
                        if(seq>maxSeq)
                        {
                            maxSeq = seq;
                         
                        }
                        seq = 1;
                    }
                }
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                }
                seq = 1;
            }
            //second part
            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int checkRow = row, checkCol = 0; checkRow < matrix.GetLength(0) - 1 && checkCol < matrix.GetLength(1) - 1; checkRow++, checkCol++)
                {
                    if (matrix[checkRow, checkCol] == matrix[checkRow + 1, checkCol + 1])
                    {
                        seq++;
                    }
                    else
                    {
                        maxSeq = Math.Max(seq, maxSeq);
                        seq = 1;
                    }
                }
                maxSeq = Math.Max(seq, maxSeq);
                seq = 1;
            }

            //diagonal '/'
            //first part
            for (int col = matrix.GetLength(1) - 1; col >= 0;col-- )
            {
                for(int checkRow=0,checkCol=col;checkRow<matrix.GetLength(0)-1 && checkCol>0;checkRow++,checkCol--)
                {
                    if(matrix[checkRow,checkCol]==matrix[checkRow+1,checkCol-1])
                    {
                        seq++;
                    }
                    else
                    {
                        if (seq > maxSeq)
                            maxSeq = seq;
                        seq = 1;
                    }
                   
                }
                if (seq > maxSeq)
                    maxSeq = seq;
                seq = 1;
            }
            //second part

            for (int row = 0; row < matrix.GetLength(0);row++ )
            {
                for(int checkRow=row,checkCol=matrix.GetLength(1)-1;checkRow<matrix.GetLength(0)-1 && checkCol>0;checkRow++,checkCol--)
                {
                    if(matrix[checkRow,checkCol]==matrix[checkRow+1,checkCol-1])
                    {
                        seq++;
                    }
                    else
                         if (seq > maxSeq)
                             maxSeq = seq;
                             seq = 1;
                }
                 if (seq > maxSeq)
                    maxSeq = seq;
                seq = 1;
            }







                Console.WriteLine(maxSeq);
        }
    }
}

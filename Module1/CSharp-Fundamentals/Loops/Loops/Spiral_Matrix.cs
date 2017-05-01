using System;
namespace Loops
{
    class Spiral_Matrix
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix=new int[N,N];

            int length = N;
            int innerSquares = (int)Math.Ceiling(N / 2.0);
            int counter = 1;

            for(int i=0;i<innerSquares;i++)
            {
               //Fill top...
                for(int j=0;j<N;j++)
                {
                    matrix[(i + j) , i] = counter++;
                }

                //Fill right...
                for(int j=1;j<N;j++)
                {
                    matrix[(N - 1 + i), j+i] = counter++;
                }
                //Fill bottom
                for (int j = N-2; j>0;j-- )
                {
                    matrix[(j+i) , (N - 1 + i)] = counter++;
                }
                //Fill left
                for (int j = N - 1; j > 0;j-- )
                {
                    matrix[i, (j + i)] = counter++;
                }
                    N = N - 2;
            }


            for(int i=0;i<length;i++)
            {
                for(int j=0;j<length;j++)
                {
                    Console.Write("{0} ",matrix[j,i]);
                }
                Console.WriteLine();
            }


        }
    }
}
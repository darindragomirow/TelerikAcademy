using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
    class Matrix<T> 
    {
        private T[,] matrix;
        public Matrix(int row,int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row,int col]
    {
        get { return this.matrix[row, col]; }
        set
        {
            this.matrix[row, col] = value;
        }
    }

        public static Matrix<T> operator +(Matrix<T> m1,Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) || m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException();
            }
            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
            for(int i=0;i<m1.matrix.GetLength(0);i++)
            {
                for(int j=0;j<m1.matrix.GetLength(1);i++)
                {
                    result.matrix[i, j] =(dynamic) m1.matrix[i, j] + m2.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) || m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException();
            }
            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m1.matrix.GetLength(1); i++)
                {
                    result.matrix[i, j] = (dynamic)m1.matrix[i, j] - m2.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1,Matrix<T> m2)
        {
            if(m1.matrix.GetLength(0)!= m2.matrix.GetLength(1))
            {
                throw new ArgumentException();
            }

            Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));
            
            for(int i=0;i<m1.matrix.GetLength(0);i++)
            {
                for(int j=0;j<m2.matrix.GetLength(1);j++)
                {
                    T temp = default(T);
                    for (int counter = 0; counter < m1.matrix.GetLength(1); counter++)
                    {
                         temp+= (dynamic)m1.matrix[i, counter] * m2.matrix[counter,j];
                    }
                    result.matrix[i, j]=temp;
                } 
                //result.matrix[i,j]=m1[i,j]*m2[i,j] + m1[i,j+1]*m2[i+1,j]+m1[i,j+2]*m2[i+2,j];
                //i=0,1,2;j=0
                //i=0;j=0,1,2
            }
            return result;
        }
    }
}

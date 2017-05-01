using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Q = N;
            for(int i=1;i<=N;i++)
            {
                for (int j = i; j <= Q;j++ )
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
                Q++;
            }
        }
    }
}

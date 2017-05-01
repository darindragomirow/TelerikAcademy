using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO
{
    class Interval
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            for(int i=N+1;i<M;i++)
            {
                if(i%5==0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

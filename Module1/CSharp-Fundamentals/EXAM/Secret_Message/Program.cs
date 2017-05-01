using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] numbers = new string[N];
            int[] numbers2 = new int[N];
            for(int i=0;i<N;i++)
            {
                numbers[i] = Console.ReadLine();
            }

           for (int i = 0; i < N-1; i++)
            {
                Console.Write("{0}{1} ",numbers[i][1],numbers[i+1][0]);
                
            }
           for (int i = 0; i < N; i++)
           {
               numbers2[i] = int.Parse(numbers[i]);
           }
           Console.WriteLine();

           for (int i = 0; i < N-1; i++)
           {
               Console.Write("{0} ",numbers2[i] + numbers2[i+1]);
           }
           Console.WriteLine();

         

            
            
            
            
        }
    }
}

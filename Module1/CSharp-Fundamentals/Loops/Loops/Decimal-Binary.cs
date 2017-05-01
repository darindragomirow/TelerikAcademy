using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Decimal_Binary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
          
            int[] result=new int[100];
            int i = 0;
            for(int value=number;value>=1;value/=2,i++)
            { 
                if(value % 2 !=0)
                {
                    result[i]=1;
                }
                else
                {
                    result[i]=0;
                }
            }
            for(int q=i-1;q>=0;q--)
            {
                Console.Write(result[q]);
            }

        }

       
    }
}

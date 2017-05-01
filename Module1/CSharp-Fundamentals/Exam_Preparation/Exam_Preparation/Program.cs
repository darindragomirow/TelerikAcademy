using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            char ch =char.Parse(Console.ReadLine());

            int topLength=(S/2);
            int middleLength=(S/3);
            int bottomLength = topLength;
            int spaces = 0;
            int size=S;

            for(int j=0;j<topLength;j++)
            {
                for (int i = 0; i < spaces;i++ )
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < size; i++)
                 {
                    Console.Write(ch);
                 }
                if (j <= topLength - 2)
                {
                    for (int i = 0; i < S; i++)
                    {
                        Console.Write(" ");
                    }
                   
                }
                else
                {
                    for(int i=0;i<S;i++)
                    {
                        if(i==(S/2)-1 || i==((S/2)+1))
                        {
                            Console.Write(ch);
                        }
                        else Console.Write(" ");
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    Console.Write(ch);
                }

                Console.WriteLine();
                spaces++;
                size--;

            }
            
            string start=new string(' ',spaces);
            string middle = new string(ch, (S * 2 + 1));
            for(int i=0;i<(S/2);i++)
            {
                Console.Write("{0}{1}",start,middle);
                Console.WriteLine();
            }

            start = new string(' ', (3 * S - (S - 2)) / 2);
            middle = new string(ch, S - 2);

            for(int i=0;i<bottomLength;i++)
            {
                middle = new string(ch, S - 2 - 2 * i);
                Console.WriteLine("{0}{1}",start+new string(' ',i),middle);
            }

            





        }
    }
}

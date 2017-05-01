using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Message
{
    class Secret
    {
        static void Main(string[] args)
        {
            string read;
            int S;
            int E;
            string text;
            int line = 1;
            int index;
            int startIndex;
            int endIndex;
            List<char> result = new List<char>();
               while((read=Console.ReadLine()) !="end")
               {
                   S = int.Parse(read);
                   E = int.Parse(Console.ReadLine());
                   text = Console.ReadLine();
                   

                   if(line%2==0)
                   {
                       index = 4;
                   }
                   else
                   {
                       index = 3;
                   }

                   if (S >= 0 && E >= 0)
                   {
                       if (S == E)
                       {
                           result.Add(text[S]);
                       }
                       else
                       {
                           for (int i = S; i < E; i += index)
                           {
                               result.Add(text[i]);

                           }
                       }
                   }
                   else
                   {
                       startIndex = S;
                       endIndex = E;
                        if(S<0)
                        {
                            startIndex = text.Length +S;
                        }
                       if(E<0)
                       {
                           endIndex = text.Length + E;
                       }
                       if (startIndex <= E)
                       {
                           result.Add(text[startIndex]);
                       }
                       if(S<E && (S<0 && E<0))
                       {
                           for(int i=startIndex;i<endIndex;i+=index)
                           {
                               result.Add(text[i]);
                           }
                       }
                       else if(S<0)
                       {
                           for (int i = startIndex; i > endIndex;i-=index)
                           {
                               result.Add(text[i]);
                              
                           }
                       }
                       else if(S>0)
                       {
                           for (int i = startIndex; i < endIndex; i += index)
                           {
                               result.Add(text[i]);

                           }
                       }
                   }
                   //Console.WriteLine();
                   line++;
               }
               
            for(int i=0;i<result.Count;i++)
            {
                Console.Write(result[i]);
            }
              
        }


    }
}

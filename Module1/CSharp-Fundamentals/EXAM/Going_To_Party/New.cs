using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going_To_Party
{
    class New
    {
        static void Main(string[] args)
        {   

        string direction = Console.ReadLine();
        int currentIndex = 0;
        char currentElement=direction[0];


        while(true)
        {
            if(currentElement=='^')
            {
                Console.WriteLine("Djor and Djano are at the party at {0}!",currentIndex); break;
            }
           else if(char.IsLower(currentElement))
           {
               currentIndex += (currentElement - 97 + 1);
           }else if(char.IsUpper(currentElement))
           {
              currentIndex-=(currentElement -65+1);
           }
         
           if(currentIndex<0 || currentIndex>=direction.Length)
           {
                Console.WriteLine("Djor and Djano are lost at {0}!", currentIndex); break;
           }
           currentElement = direction[currentIndex];

        }

        }
    }
}

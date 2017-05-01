using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Print_Deck
    {
        static void Main(string[] args)
        {
            string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            
            string sign = (Console.ReadLine());
           
            int index = 0;
            foreach(string s in deck)
            {
                if(s==sign)
                {
                    break;
                }
                index++;
            }


                for (int i = 0; i <= index; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
                }
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class PlayCards
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            string allCards = "2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A";
            int found = allCards.IndexOf(card);
            if(found != -1)
            {
                Console.WriteLine("yes "+card);
            }
            else
            {
                Console.WriteLine("no "+card);
            }
        }
    }
}

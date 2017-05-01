using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }

            ///////////////////////////
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && shouldVisitCell)))
            {
                VisitCell();
            }
        }
    }
}

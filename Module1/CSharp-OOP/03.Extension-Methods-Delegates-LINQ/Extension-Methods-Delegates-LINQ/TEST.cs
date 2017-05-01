using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Extension_Methods_Delegates_LINQ
{
    class TEST
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("This is a sample test!");
            
            Console.WriteLine(builder.Substring(0,4).ToString());
        }
    }
}

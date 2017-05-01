using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Int_String_Double
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type=="text")
            {
                string text = Console.ReadLine();
                Console.WriteLine(text+"*");
            }else if(type=="real")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",++num);
            }else if(type=="integer")
            {
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(++num1);
            }
        }
    }
}

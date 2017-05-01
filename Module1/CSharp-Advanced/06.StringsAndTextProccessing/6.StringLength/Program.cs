using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string readText = Console.ReadLine();
            StringBuilder text = new StringBuilder(readText);
            int length=text.Length;
            if(length<20)
            {
                for(int i=length;i<20;i++)
                {
                    text.Append('*');
                }
            }
            Console.WriteLine(text);
            
        }
    }
}

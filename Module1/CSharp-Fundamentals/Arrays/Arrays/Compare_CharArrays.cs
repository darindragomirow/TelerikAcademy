using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Compare_CharArrays
    {
        static void Main(string[] args)
        {
            string array1 = Console.ReadLine();
            string array2 = Console.ReadLine();
            int flag = 1;
            for (int i = 0; i <array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    flag = 0; break;
                }
            }
            if( flag != 0 )
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(array1.Length > array2.Length ? ">":"<");
            }
        }
    }
}

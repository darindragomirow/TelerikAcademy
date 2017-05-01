using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Expressions
{
    class Rectangle_Area
    {
        public static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = width * height;
            float P = 2 * (width + height);
            Console.WriteLine(area.ToString("f2")+" ");
            Console.WriteLine(P.ToString("f2"));
        }
    }
}

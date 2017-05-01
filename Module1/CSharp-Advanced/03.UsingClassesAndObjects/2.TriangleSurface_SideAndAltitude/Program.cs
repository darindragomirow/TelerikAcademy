using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TriangleSurface_SideAndAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double surface = ((side * altitude)/ 2);
            Console.WriteLine("{0:F2}",surface);
        }
    }
}

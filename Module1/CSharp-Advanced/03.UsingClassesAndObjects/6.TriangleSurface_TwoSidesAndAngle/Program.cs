using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TriangleSurface_TwoSidesAndAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            //Y(in radians)=Math.PI*Y(degrees)/180
            Y = Math.PI *Y / 180.0;
            double surface = (a * b * Math.Sin(Y)) / 2;
            Console.WriteLine("{0:F2}",surface);
        }
    }
}

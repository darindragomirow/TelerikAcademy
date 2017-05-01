using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
   public static class DistanceBetweenTwoPoints3D
    {
        public static double CalculateDistance(Point3d.Point3D p1,Point3d.Point3D p2)
        {
            double distance = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2));
            return distance;
        }
    }
}

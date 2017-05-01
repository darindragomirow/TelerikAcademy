using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
    public class Point3d
    {
       public struct Point3D
       {
           private double x;
           private double y;
           private double z;
           public double X
           {
               get { return this.x; }
               set { this.x = value; }
           }
           public double Y
           {
               get { return this.y; }
               set { this.y = value; }
           }
           public double Z
           {
               get { return this.z;}
               set { this.z = value;}
           }
           
           public Point3D(double X,double Y,double Z)
           {
               this.x = X;
               this.y = Y;
               this.z = Z;
           }
           
           public static readonly Point3D o = new Point3D(0, 0, 0);
           public Point3D O
           {
               get { return o;}
           }

           public override string ToString()
           {
               StringBuilder builder = new StringBuilder();
               builder.Append("X= " + this.X).Append(",").Append("Y= " + this.Y).Append(",").Append("Z= " + this.Z);
               return builder.ToString();
           }

          
       }
    }
}

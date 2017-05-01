using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
   public static class PathStorage
    {

       public static void writePath(Point3d.Point3D[] points)
       {
  
           using(StreamWriter writer = new StreamWriter("Paths.txt"))
           {
               foreach(var p in points)
               {
                   writer.WriteLine(string.Join(",",new string[]{p.X.ToString(),p.Y.ToString(),p.Z.ToString()}));
               }
           }
       }

       public static List<Point3d.Point3D> readPaths()
       {
           var result=new List<Point3d.Point3D>();
           using (StreamReader reader = new StreamReader("Paths.txt"))
           {
              string line;
              while( (line=reader.ReadLine()) !=null )
              {
                  string[] coordinates=line.Split(',');
                  result.Add(new Point3d.Point3D(double.Parse(coordinates[0]),double.Parse(coordinates[1]),double.Parse(coordinates[2])));
              }
               return result;
           }    
           }
       }
    }


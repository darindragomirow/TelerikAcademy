using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.DefiningClassesPart2
{
   public class Path
    {
       Point3d.Point3D[] sequenceOfPaths { get; set; }
       public Path(Point3d.Point3D[] sequenceOfPaths)
       {
           this.sequenceOfPaths = sequenceOfPaths;
       }
    }
}

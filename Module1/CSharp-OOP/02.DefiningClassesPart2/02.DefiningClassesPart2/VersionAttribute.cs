using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
    [AttributeUsage(AttributeTargets.All)]
    public class VersionAttribute :System.Attribute
    {

        public VersionAttribute(string version)
        {
            this.version = version;
        }

        public string version { get; set; }
    }
}

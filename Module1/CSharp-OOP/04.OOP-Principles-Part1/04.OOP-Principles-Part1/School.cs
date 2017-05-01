using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part1
{
    public class School
    {
        public School(List<Class> classes)
        {
            this.classes = classes;
        }
        private List<Class> classes { get; set; }
        public void addClass(Class cls)
        {
            classes.Add(cls);
        }

    }
}

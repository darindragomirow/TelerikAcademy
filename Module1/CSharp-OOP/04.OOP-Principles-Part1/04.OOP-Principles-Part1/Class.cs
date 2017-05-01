using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part1
{
   public  class Class
    {

        public Class(string textIdentifier,List<Student> students,List<Teacher> teachers)
        {
            this.textIdentifier = textIdentifier;
            this.students = students;
            this.teachers = teachers;
        }
        private string textIdentifier { get; set; }
       private List<Student> students { get; set; }
       private List<Teacher> teachers { get; set; }
       private string optionalComments { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_LINQ
{
    public static class StudentExtension
    {
        public static List<Student> GroupStudentsEx(this List<Student> list)
        {
            var group2 = list.Where(student => student.GroupNumber == 2).ToList();
            return group2;
        }

        public static List<Student> ExtractTwoMarks(this List<Student> list)
        {
            var result = new List<Student>();
            foreach(var student in list)
            {
                if(student.Marks.Contains(2))
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}

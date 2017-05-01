using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_LINQ
{
   public class Student
    {
        public string Email { get; private set; }
        public string FacultyNumber { get; private set; }
        public string FirstName { get; private set; }
        public int GroupNumber { get; private set; }
        public string LastName { get; private set; }
        public List<double> Marks { get; private set; }
        public string Telephone { get; private set; }
        public int Age { get; private set; }

        public Student(string Email,string FacultyNumber,string FirstName,int GroupNumber,string LastName,List<double> Marks,
            string Telephone,int Age)
    {
        this.Email = Email;
        this.FacultyNumber = FacultyNumber;
        this.FirstName = FirstName;
        this.GroupNumber = GroupNumber;
        this.LastName = LastName;
        this.Marks = Marks;
        this.Telephone = Telephone;
        this.Age = Age;
    }
        public Student() { }



        
    }
}

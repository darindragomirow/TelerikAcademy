using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
   public class Student:Human
    {

       public Student(string firstName,string lastName,int grade):base(firstName,lastName)
       {
           this.grade = grade;
       }
       public int grade { get; set; }
    }
}

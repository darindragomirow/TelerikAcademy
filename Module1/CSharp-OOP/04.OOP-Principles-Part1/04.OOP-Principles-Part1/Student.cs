using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part1
{
    public class Student:Person
    {

        public Student(string firstName,string lastName,string classNumber):base(firstName,lastName)
        {
            this.classNumber = classNumber;
        }
        string classNumber { get; set; }
        string optionalComment { get; set; }


    }
}

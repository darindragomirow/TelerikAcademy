using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part1
{
    public class Teacher:Person
    {

        public Teacher(string firstName,string lastName,List<Discipline> disciplines):base(firstName,lastName)
        {
            this.disciplines = disciplines;
        }

        private List<Discipline> disciplines { get; set; }
        private string optionalComments { get; set; }

        public void addDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OOP_Principles_Part1
{
    public class Discipline
    {
        public Discipline(string name,int numberOfExcersises,int numberOfLectures)
        {
            this.name = name;
            this.numberOfExcersises = numberOfExcersises;
            this.numberOfLectures = numberOfLectures;
        }

        private string name { get; set; }
        private int numberOfExcersises { get; set; }
        private int numberOfLectures { get; set; }

        private string optionalComments { get; set; }
    }
}

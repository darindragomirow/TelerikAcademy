using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    public abstract class Human
    {
        public Human(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
         public string firstName {get; set; }
         public string lastName { get; set; }

    }
}

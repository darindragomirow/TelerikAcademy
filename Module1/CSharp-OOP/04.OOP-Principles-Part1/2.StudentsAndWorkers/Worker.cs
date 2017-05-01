using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
   public class Worker:Human
    
    {
       public Worker(string firstName,string lastName,double weekSalary,int workHours):base(firstName,lastName)
       {
           this.weekSalary = weekSalary;
           this.workHours = workHours;
       }
       private double weekSalary { get; set; }
       private int workHours { get; set; }

       public double MoneyPerHour()
       {
           return this.weekSalary /40;
       }
    }
}

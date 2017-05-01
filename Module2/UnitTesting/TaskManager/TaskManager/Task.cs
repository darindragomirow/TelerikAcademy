using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
   public class Task
    {
       public Task(string description,DateTime ? deadLine)
       {
           this.Description = description;
           this.deadLine = (DateTime)deadLine;
       }
       public int Id {get;set;}
       public string Description { get; set; }
       public DateTime ? deadLine { get; set; }
       public bool isDone { get; set; }
    }
}

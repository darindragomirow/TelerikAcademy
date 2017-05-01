using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Client
    {
        static void Main(string[] args)
        {
            var taskManager = new TaskManager();
            var task1 = new Task("Izmii kolata!",DateTime.Now.AddDays(2));
            var task2 = new Task("Kupi hlqb", DateTime.Now.AddHours(2));
            taskManager.Save(task1);
            taskManager.Save(task2);
        }
    }
}

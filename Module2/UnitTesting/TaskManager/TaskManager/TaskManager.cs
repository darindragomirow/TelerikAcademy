using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskManager
    {
        private ILogger logger;
        private IIdProvider provider;
        public ICollection<Task> Tasks { get; set; }
        public TaskManager(ILogger logger,IIdProvider provider)
        {
            this.Tasks=new List<Task>();
            this.logger = logger;
            this.provider = provider;
        }

        public void Save(Task task)
        {
            if(task==null)
            {
                throw new ArgumentNullException();
            }
            task.Id = this.provider.Id;
            this.Tasks.Add(task);
            this.logger.Log("The task has been added");
        }

        public void Delete(int id)
        {
            var taskFound = this.Tasks.SingleOrDefault(task => task.Id == id);
            if(taskFound==null)
            {
                logger.Log("Such task is not found!");
                return;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class Database
    {
        public List<Task> Tasks { get; set; }

        public Database()
        {
            Tasks = new List<Task>();
        }

       /* public List<Task> SortingTasksByMonth(Month targetMonth, Day targetDay, TaskTime targetTaskTime)
        {
            return Tasks
            .Where(task => task.month == targetMonth && task.day == targetDay && task.taskTime == targetTaskTime)
            .ToList();
        }*/

        public string DisplayTask(List<Task> tasks)
        {
            string toReturn = "";

            foreach (Task task in tasks)
            {
                toReturn += tasks.ToString() + "\n";
            }

            return toReturn;

        }
    }
}
    
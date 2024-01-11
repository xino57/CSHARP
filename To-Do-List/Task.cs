using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace To_Do_List
{
    internal class Task
    {
        public string Description { get; set; }
        public Month month { get; set; }
        public Day day { get; set; }
        public TaskTime taskTime { get; set; }

        public Task(string description, Month month, Day day, TaskTime taskTime)
        {
            Description = description;
            this.month = month;
            this.day = day;
            this.taskTime = taskTime;
        }

        public bool IsSameTask(Task otherTask)
        {
            return Description == otherTask.Description &&
           month == otherTask.month &&
           day == otherTask.day &&
           taskTime == otherTask.taskTime;
        }
        public void udapteTask(string newDescription, Month newMonth, Day NewDay, TaskTime NewTaskTime)
        {
            Description = newDescription;
            month = newMonth;
            day = NewDay;
            taskTime = NewTaskTime;
        }

        public bool IsValid(string description, Month month, Day day)
        {
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Entrez votre description s'il vous plaît");
                return false;
            }
            else if (month == null)
            {
                MessageBox.Show("Vous êtes obligé de rentrer un mois");
                return false;
            }
            else if (day == null)
            {
                MessageBox.Show("Vous êtes obligé de rentrer un jour");
                return false;
            }

            return true;
        }

        // Méthode de formatage des détails d'une tâhe 

        public string FormatTaskDetails()
        {
            string formattedDetails = $"Description : {Description}\n";
            formattedDetails += $"Month       : {month}\n";
            formattedDetails += $"Day         : {day}\n";
            formattedDetails += $"Task Time   : {taskTime}";

            return formattedDetails;
        }

    }
}

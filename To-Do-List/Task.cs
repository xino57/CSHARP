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
    public class Task
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string DatePicker { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }

        public string taskTime { get; set; }

        public Task(string title, string description, string datePicker, string day, string month, string tasktime)
        {
            Title = title;
            Description = description;
            DatePicker = datePicker;
            Day = day;
            Month = month;
            taskTime= tasktime;
        }

        public bool IsValid(string title, string description, Month month, Day day)
        {

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Entrez un titre s'il vous plaît");
                return false;
            }
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

       /* public string FormatTaskDetails()
        {
            string formattedDetails = $"Description : {Description}\n";
            formattedDetails += $"Month       : {month}\n";
            formattedDetails += $"Day         : {day}\n";
            formattedDetails += $"Task Time   : {taskTime}";

            return formattedDetails;
        }*/

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Formulaire_WPF
{
    public class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Month Month{ get; set; }

        public bool NewsLetters { get; set; }

        public User(string lastName, string firstName, Month month, bool newsLetters)
        {
            LastName = lastName;
            FirstName = firstName;
            Month = month;
            NewsLetters = newsLetters;
        }

    }


    
}

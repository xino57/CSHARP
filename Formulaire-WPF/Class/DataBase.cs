using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire_WPF
{
    public class DataBase
    {
        public List<User> ListBD { get; set; }

        public DataBase() 
        { 
            ListBD = new List<User>();
        }
        public DataBase(List<User> listBD)
        {
            ListBD = listBD;
        }
    }
}

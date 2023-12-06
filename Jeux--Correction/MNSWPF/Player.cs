using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNSWPF
{
    public class Player : INotifyPropertyChanged
    {
        private int hP;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int HP
        {
            get { return hP; }
            set {
                if (hP != value)
                {
                    hP = value;
                    NotifyPropertyChanged("HP");
                }
            }
        }

        public Player(int hP)
        {
            HP = hP;
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

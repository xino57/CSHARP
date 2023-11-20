using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNS
{
    public class Alarm
    {
        public string Message { get; set; }

        public Alarm(string message)
        {
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public void DisplayMessage()
        {
            Console.WriteLine(Message);
        }
    }
}

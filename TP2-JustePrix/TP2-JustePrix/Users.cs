using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_JustePrix
{
    public class Users
    {
        public string Pseudo { get; set; }
        public int Score { get; set; }

        public Users()
        {
            Pseudo = "inviter";
            Score = 0;
        }
        public Users(string pseudo, int score)
        {
            Pseudo = pseudo;
            Score = score;
        }
    }

}

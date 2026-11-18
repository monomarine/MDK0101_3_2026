using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Request
{
    internal class User
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Score { get; set; }

        public User( string email, string phone, double score= 0)
        {
            Email = email;
            Phone = phone;
            Score = score;
        }
    }
}

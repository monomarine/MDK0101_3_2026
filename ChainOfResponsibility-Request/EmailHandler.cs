using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Request
{
    internal class EmailHandler : Handler
    {
        public override void Handle(User user)
        {
            var email = user.Email;
            if (email.Contains('@') && email.Length > 8)
            {
                Console.WriteLine($"{email} корректен");
                _next?.Handle(user);
            }
            else
            {
                Console.WriteLine($"{email} не корректен");
                return;
            }
               
        }
    }
}

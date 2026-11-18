using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Request
{
    internal class Phonehandler : Handler
    {
        public override void Handle(User user)
        {
            var phone = user.Phone;
            if (phone.Length >= 11)
            {
                Console.WriteLine($"{phone} корректен");
                _next?.Handle(user);
            }

            else
            {
                Console.WriteLine($"{phone} не корректен");
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class SendedOrderState : IOrderState
    {
        public void Cancel(Order order)
        {
            Console.WriteLine("нельзя отменить заказ - доставляется");
        }

        public string getStatus()
        {
            return "статус - в доставке";
        }

        public void Pay(Order order)
        {
            Console.WriteLine("заказ уже оплачен");
        }

        public void Send(Order order)
        {
            Console.WriteLine("заказ уже отправлен");
        }
    }
}

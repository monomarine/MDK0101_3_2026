using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PayedOrderState : IOrderState
    {
        public void Cancel(Order order)
        {
            Console.WriteLine("нельзя отменить оплаченный заказ");
        }

        public string getStatus()
        {
            return "статус - оплачен";
        }

        public void Pay(Order order)
        {
            Console.WriteLine("заказ уже оплачен");
        }

        public void Send(Order order)
        {
            Console.WriteLine("заказ отправлен");
            order._state = new SendedOrderState();
        }
    }
}

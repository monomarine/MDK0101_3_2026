using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NewOrderState : IOrderState
    {
        public void Cancel(Order order)
        {
            Console.WriteLine("заказ отменен");
            order._state = new CancelOrderState();
        }

        public string getStatus()
        {
            return "статус - только создан";
        }

        public void Pay(Order order)
        {
            Console.WriteLine("заказ оплачен");
            order._state = new PayedOrderState();
        }

        public void Send(Order order)
        {
            Console.WriteLine("нельзя отправить неоплаченный заказ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CancelOrderState : IOrderState
    {
        public void Cancel(Order order)
        {
            Console.WriteLine("нельзя повторно отменить");
        }

        public string getStatus()
        {
            return "заказ отменен";
        }

        public void Pay(Order order)
        {
            Console.WriteLine("нельзя оплатить отмененный заказ");
        }

        public void Send(Order order)
        {
            Console.WriteLine("нельзя отправить отмененный заказ");
        }
    }
}

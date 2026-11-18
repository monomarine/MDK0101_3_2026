using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Order
    {
        public IOrderState _state;
        public Order()
        {
            _state = new NewOrderState();
            Console.WriteLine("заказ создан");
        }

        public void Pay() => _state.Pay(this);
        public void Send() => _state.Send(this);
        public void Cancel() => _state.Cancel(this);
        public string getStatus() => _state.getStatus();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Orders
{
    internal abstract class OrderDecorator : IOrder
    {
        private IOrder _order;
        public OrderDecorator(IOrder or) => _order = or;

        public virtual string GetDescroption()
        {
            return _order.GetDescroption();
        }

        public virtual decimal GetPrice()
        {
            return _order.GetPrice();
        }
    }
}

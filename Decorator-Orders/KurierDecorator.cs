using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Orders
{
    internal class KurierDecorator : OrderDecorator
    {
        public KurierDecorator(IOrder order) : base(order)
        {
        }

        public override string GetDescroption()
        {
            return base.GetDescroption() + "Доставка курьером";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 500;
        }


    }
}

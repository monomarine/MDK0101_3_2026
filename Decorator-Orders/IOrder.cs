using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Orders
{
    internal interface IOrder
    {
        string GetDescroption();
        decimal GetPrice();

    }
}

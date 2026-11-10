using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Decorator_Orders
{
    internal class Computer : IOrder
    {
        public string GetDescroption()
        {
            return "ПК";
        }

        public decimal GetPrice()
        {
            return 100000;
        }
    }
}

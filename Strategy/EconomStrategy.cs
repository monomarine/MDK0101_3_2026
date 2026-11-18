using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class EconomStrategy : IPaymentStrategy
    {
        private double _baseDistance = 3;
        private double _basePrice = 20;
        public double Calculate(double distance)
        {
            if (distance >= _baseDistance)
                return distance * _basePrice;

            else
                return _basePrice * _baseDistance;
        }
    }
}

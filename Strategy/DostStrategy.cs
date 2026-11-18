using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class DostStrategy : IPaymentStrategy
    {
        private double _basePrice = 100;
        private double _baseDistance = 5;
        
        public double Calculate(double distance)
        {
            if (distance >= _baseDistance)
                return distance * _basePrice;

            else
                return _basePrice * _baseDistance;
        }
    }
}

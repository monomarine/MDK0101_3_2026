using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// контекст - расчет стоимости такси
    /// </summary>
    internal class Taxi
    {
        private IPaymentStrategy _strategy;
        public Taxi(IPaymentStrategy st)
        {
            _strategy = st;
        }

        public double Calculate(double distance)
        {
            if (_strategy != null)
            {
                return _strategy.Calculate(distance);
            }
            else throw new ArgumentNullException("не назначена стратегия");
        }
    }
}

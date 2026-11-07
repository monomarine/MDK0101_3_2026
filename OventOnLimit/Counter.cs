using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OventOnLimit
{
    /// <summary>
    /// класс-издатель события
    /// </summary>
    internal class TiketSaler
    {
        private readonly int _ticketCount = 100; //лимит
        private int _soldTiket = 0;

        public event EventHandler<TiketSoldEventArgs>? ReachLimit;

        public void SaleTiket()
        {
            _soldTiket++;
            if (_soldTiket == _ticketCount)
            {
                ReachLimit?.Invoke(this, new TiketSoldEventArgs(_ticketCount));
            }
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OventOnLimit
{
    internal class TiketSoldEventArgs : EventArgs
    {
        public int TicketCount { get; }
        public TiketSoldEventArgs  (int count) => TicketCount = count;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    internal class Subcription : IDisposable
    {
        private Action? _dispose;
        public Subcription(Action act) => _dispose = act;

        public void Dispose()
        {
            _dispose?.Invoke();
            _dispose = null;
        }
    }
}

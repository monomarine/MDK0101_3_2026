using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Request
{
    /// <summary>
    /// базовый класс для всех звеньев цепи
    /// </summary>
    internal abstract class Handler
    {
        protected Handler _next; //ссылка на сл звено
        public Handler SetNext(Handler h)
        {
            _next = h;
            return _next;
        }

        public abstract void Handle(User user);
    }
}

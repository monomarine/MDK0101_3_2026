using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace State
{
    internal interface IOrderState
    {
        void Pay(Order order);
        void Send(Order order);
        void Cancel(Order order);
        string getStatus();
    }
}

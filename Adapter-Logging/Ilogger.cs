using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Logging
{
    internal interface ILogger
    {
        void Log(string message, LogLevel level);
    }
}

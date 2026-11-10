using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Logging
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message, LogLevel level)
        {
            Console.WriteLine($"[{level}]>> {DateTime.Now} - <<{message}>>");
        }
    }
}

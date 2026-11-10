using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using NLog;

namespace Adapter_Logging
{
    public enum LogLevel
    {
        Info = 0, Warning = 1, Debug = 3, Fatal = 4, Trace = 2
    }
    internal class NLogAdapner : ILogger
    {
        private readonly Logger _logger;

        public NLogAdapner(Logger l)
        {
            _logger = l;
        }
        public void Log(string message, LogLevel level)
        {
            switch(level)
            {
                case LogLevel.Info:
                    _logger.Info(message); break;
                case LogLevel.Warning:
                    _logger.Warn(message); break;
                case LogLevel.Debug:
                    _logger.Debug(message); break;
                case LogLevel.Fatal:
                    _logger.Fatal(message); break;
                case LogLevel.Trace:
                    _logger.Trace(message); break;
                default: throw new ArgumentException("Уровень логирования не определен");
            }
        }
    }
}

using NLog;
namespace Adapter_Logging

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            NLogAdapner newLogger = new NLogAdapner(LogManager.GetCurrentClassLogger());
            

            List<ILogger> loggerList = new List<ILogger>();
            loggerList.Add(consoleLogger);
            loggerList.Add(newLogger);

            foreach(var logger in loggerList)
            {
                logger.Log("пользователь User3127 успешно авторизован", LogLevel.Info);
            }
            
        }
    }
}

using NLog;
using NLog.Config;
using NLog.StructuredLogging.Json;

namespace LoggingExample
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            LogManager.Configuration = new XmlLoggingConfiguration("nlog.config");

            var logger = LogManager.GetLogger(typeof(Program).FullName);

            logger.Info("Hello World!");
            logger.ExtendedInfo("Extended Greetings!", new {WordOfTheDay = "Jibble"});
            logger.ExtendedInfo("Different Value Types 1", new {Number = 12345});
            logger.ExtendedInfo("Different Value Types 2", new {Number = "Qwer?"});

            logger.Factory.Flush();
        }
    }
}
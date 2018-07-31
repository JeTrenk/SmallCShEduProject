using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interfaces
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");

        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)//dependancy injector
        {
            this._logger = logger;
        }  

        public void Migrate()//define concrete class that implement ILogger
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            
            //details

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Start
{
    public class MemoryLogger
    {
        private List<LogMessage> _logMessages = new List<LogMessage>();
        public IReadOnlyCollection<LogMessage> LogMessages => _logMessages.AsReadOnly();
        private int _LogCount = 0;
        private int _errorCount = 0;
        private int _warningCount = 0;
        // cli search for static instance of MemoryLogger and create a new instance if it doesn't exist in start 

        // eagr loading singleton pattern implementation at startup
        private static  MemoryLogger _instance =new MemoryLogger();
        private static readonly object _lock = new object();
        public static MemoryLogger Instance
        {
            get
            {
                return _instance;
            }
        }
        private MemoryLogger()
        {
            
        }
        public void LogInfo(string message)
        {
            var logMessage = new LogMessage
            {
                Message = message,
                Type = LogType.Info,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now)
             };
            _logMessages.Add(logMessage);
            _LogCount++;
        }
        public void LogWarning(string message)
        {
            var logMessage = new LogMessage
            {
                Message = message,
                Type = LogType.Warning,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now)
            };
            _logMessages.Add(logMessage);
            _warningCount++;
        }

        public void LogError(string message)
        {
            var logMessage = new LogMessage
            {
                Message = message,
                Type = LogType.Error,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now)
            };
            _logMessages.Add(logMessage);
            _errorCount++;
        }
        public void PrintLogSummary()
        {
            foreach (var logMessage in _logMessages)
            {
                Console.WriteLine(logMessage.Message);
            }   
            Console.WriteLine($"Total Logs: {_LogCount}");
            Console.WriteLine($"Total Warnings: {_warningCount}");
            Console.WriteLine($"Total Errors: {_errorCount}");
        }   
    }
}

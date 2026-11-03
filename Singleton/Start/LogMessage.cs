using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Start
{
    public class LogMessage
    {
        public string Message { get; set; }
        public LogType Type { get; set; }

        public DateOnly CreatedAt { get; set; }
        public override string ToString()
        {
            var createdAt = CreatedAt.ToString("yyyy-MM-dd hh:mm:ss");
            return $"[{createdAt}] [{Type}] {Message}";
        }
    }
}

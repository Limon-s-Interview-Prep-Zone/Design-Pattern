using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;

namespace AdapterPattern
{
    public class FileLoggerAdapter<T> : FileStream, ILogger<T>
    {
        public FileLoggerAdapter(string path) : base(path, FileMode.Append)
        {
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            var messageByteArray = new UTF8Encoding(true)
                .GetBytes(state + "\n");

            Write(messageByteArray, 0, messageByteArray.Length);
            Flush();
        }
    }
}
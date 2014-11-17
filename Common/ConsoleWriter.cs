using System;
using System.Collections.Generic;
using System.Text;

namespace DataMonitor.Common
{
    public sealed class ConsoleWriter : ActionWriter
    {
        public void Write(string content)
        {
            Console.WriteLine("Read {0} bytes from socket. \n Data : {1}", content.Length, content);
        }

        public void Write(object message)
        {
            Write(message == null ? message.ToString() : "null");
        }
    }
}

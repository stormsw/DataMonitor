using System;
using System.Collections.Generic;
using System.Text;

namespace DataMonitor.Common
{
    public interface ActionWriter
    {
        void Write(string message);
        void Write(object message);
    }
}

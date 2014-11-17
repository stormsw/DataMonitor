using System;
using System.Collections;
using System.Collections.Generic;
using System.Messaging;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace AsyncServer
{    
    class Program
    {
        static int Main(string[] args)
        {
            AsynchronousSocketListener.StartListening();
            return 0;
        }
    }
}
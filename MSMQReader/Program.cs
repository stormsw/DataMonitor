using System;
using System.Collections.Generic;
using System.Text;
using DataMonitor.Common;
using System.Messaging;

namespace MSMQReader
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue messageQueue = new MessageQueue(MessageQueueWriter.MSMQ_NAME);
            while (messageQueue.CanRead)
            {
                Message message = null;
                string body = string.Empty;

                try
                {
                    message = messageQueue.Receive(new TimeSpan(0, 0, 3));
                    message.Formatter = new XmlMessageFormatter(
                      new String[] { "System.String,mscorlib" });
                    body = message.Body.ToString();
                }
                catch
                {
                    body = "No Message";
                }

                Console.WriteLine(body);
            }
        }

        private static void readDiagnosticFromMQ(MessageQueue msgQ)
        {
            DiagnosticData diagnosticData = new DiagnosticData();
            Object o = new Object();
            System.Type[] arrTypes = new System.Type[2];
            arrTypes[0] = diagnosticData.GetType();
            arrTypes[1] = o.GetType();
            msgQ.Formatter = new XmlMessageFormatter(arrTypes);
            diagnosticData = ((DiagnosticData)msgQ.Receive().Body);
            Console.WriteLine(diagnosticData);
        }
    }
}

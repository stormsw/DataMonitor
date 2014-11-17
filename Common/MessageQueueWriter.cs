using System;
using System.Collections.Generic;
using System.Messaging;
using System.Text;

namespace DataMonitor.Common
{
    public sealed class MessageQueueWriter : ActionWriter
    {
        public const string MSMQ_NAME = @".\Private$\SomeTestName";
        MessageQueue messageQueue = null;
        public MessageQueueWriter()
        {
            Initialize(MSMQ_NAME);
        }        
        public MessageQueueWriter(string msmqName)
        {
            Initialize(msmqName);
        }
        private void Initialize(string msmqName)
        {
            if (MessageQueue.Exists(msmqName))
            {
                messageQueue = new MessageQueue(msmqName);
                messageQueue.Label = "Testing Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(msmqName);
                messageQueue = new MessageQueue(msmqName);
                messageQueue.Label = "Newly Created Queue";
                messageQueue.Send("First ever Message is sent to MSMQ", "Title");
            }
        }

        public void Write(string message)
        {
            messageQueue.Send(message, "Writer");
        }

        public void Write(object message)
        {
            System.Messaging.Message msg = new System.Messaging.Message();
            msg.Body = message;
            messageQueue.Send(msg);
        }

    }
}

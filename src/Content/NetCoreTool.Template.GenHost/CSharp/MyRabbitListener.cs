#if (MessagingRabbitMqListener)
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.Logging;
using Steeltoe.Messaging.Handler.Attributes;
using Steeltoe.Messaging.RabbitMQ;
using Steeltoe.Messaging.RabbitMQ.Attributes;

namespace Company.GenericHost.CS 
{
    public class MyRabbitListener
    {
        public const string RECEIVE_AND_CONVERT_QUEUE = "steeltoe_message_queue";
        private ILogger<MyRabbitListener> logger;

        public MyRabbitListener(ILogger<MyRabbitListener> logger)
        {
            this.logger = logger;
        }

        [RabbitListener(RECEIVE_AND_CONVERT_QUEUE)]
        public void Listen(string input)
        {
            logger.LogInformation(input);
        }
    }
}
#endif
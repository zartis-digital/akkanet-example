using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class SendNotificationActor : ReceiveActor
    {
        public SendNotificationActor()
        {
            Receive<SendNotification>(msg =>
            {
                Console.WriteLine($"---> Send notification {msg.Message}, type: {msg.Type}.");
            });
        }
    }
}

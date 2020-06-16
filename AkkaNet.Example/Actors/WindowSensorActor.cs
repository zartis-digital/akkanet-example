using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class WindowSensorActor : ReceiveActor
    {
        public WindowSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(WindowSensorActor)}");
                Context.Parent.Tell(new WindowSensorValueRetrieved { Value = new Random().Next(100) > 95 ? 1 : 0 });
            });
        }
    }
}

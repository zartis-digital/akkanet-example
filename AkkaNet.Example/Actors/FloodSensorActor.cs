using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class FloodSensorActor : ReceiveActor
    {
        public FloodSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(FloodSensorActor)}");
                Context.Parent.Tell(new FloodSensorValueRetrieved { Value = new Random().NextDouble() * 10 });
            });
        }
    }
}

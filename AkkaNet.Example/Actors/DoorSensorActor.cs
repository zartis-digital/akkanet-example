using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class DoorSensorActor : ReceiveActor
    {
        public DoorSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(DoorSensorActor)}");
                Context.Parent.Tell(new DoorSensorValueRetrieved { Value = new Random().Next(100) > 95 ? 1 : 0 });
            });
        }
    }
}

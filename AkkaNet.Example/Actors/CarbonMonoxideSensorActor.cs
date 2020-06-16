using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class CarbonMonoxideSensorActor : ReceiveActor
    {
        public CarbonMonoxideSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(CarbonMonoxideSensorActor)}");
                Context.Parent.Tell(new CarbonMonoxideSensorValueRetrieved { Value = new Random().NextDouble() * 30 });
            });
        }
    }
}

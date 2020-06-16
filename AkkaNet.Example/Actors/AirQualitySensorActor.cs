using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class AirQualitySensorActor : ReceiveActor
    {
        public AirQualitySensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(AirQualitySensorActor)}");
                Context.Parent.Tell(new AirQualitySensorValueRetrieved { Value = new Random().NextDouble() * 100 });
            });
        }
    }
}

using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class GasSensorActor : ReceiveActor
    {
        public GasSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(GasSensorActor)}");
                Context.Parent.Tell(new GasSensorValueRetrieved { Value = new Random().NextDouble() });
            });
        }
    }
}

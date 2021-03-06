﻿using System;
using Akka.Actor;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Actors
{
    public class MotionSensorActor : ReceiveActor
    {
        public MotionSensorActor()
        {
            Receive<ReadSensorValue>(readValueMsg =>
            {
                Console.WriteLine($"Message of type {readValueMsg.GetType()} received in actor {nameof(MotionSensorActor)}");
                Context.Parent.Tell(new MotionSensorValueRetrieved { Value = new Random().Next(100) > 95 ? 1 : 0 });
            });
        }
    }
}

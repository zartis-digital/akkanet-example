using System;
using Akka.Actor;
using AkkaNet.Example.Actors;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example.Runtime
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var system = ActorSystem.Create("MySystem");

            var houseA = system.ActorOf<HouseActor>("houseA");
            //var houseB = system.ActorOf<HouseActor>("houseB");
            //var houseC = system.ActorOf<HouseActor>("houseC");
            //var houseD = system.ActorOf<HouseActor>("houseD");
            //var houseE = system.ActorOf<HouseActor>("houseE");
            //var houseF = system.ActorOf<HouseActor>("houseF");

            houseA.Tell(new CloseHouse());
            houseA.Tell(new RegisterSensor { Type = SensorType.Gas });
            houseA.Tell(new RegisterSensor { Type = SensorType.Flood });
            houseA.Tell(new RegisterSensor { Type = SensorType.Door });
            houseA.Tell(new RegisterSensor { Type = SensorType.Motion });

            //houseB.Tell(new RegisterSensor { Type = SensorType.Gas });

            //houseC.Tell(new RegisterSensor { Type = SensorType.Gas });
            //houseC.Tell(new RegisterSensor { Type = SensorType.Door });

            //houseD.Tell(new RegisterSensor {Type = SensorType.Gas});

            //houseE.Tell(new RegisterSensor { Type = SensorType.Gas });
            //houseE.Tell(new RegisterSensor { Type = SensorType.Flood });
            //houseE.Tell(new RegisterSensor { Type = SensorType.Window });

            Console.ReadKey();
        }
    }
}

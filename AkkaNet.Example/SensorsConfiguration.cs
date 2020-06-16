using System;
using AkkaNet.Example.Messages;

namespace AkkaNet.Example
{
    internal class SensorsConfiguration
    {
        public TimeSpan GetTimeInterval(SensorType type)
        {
            return type switch
            {
                SensorType.AirQuality => TimeSpan.FromSeconds(45),
                SensorType.CarbonMonoxide => TimeSpan.FromMinutes(1),
                SensorType.Gas => TimeSpan.FromSeconds(45),
                SensorType.Flood => TimeSpan.FromHours(2),
                SensorType.Door => TimeSpan.FromSeconds(10),
                SensorType.Motion => TimeSpan.FromSeconds(5),
                SensorType.Window => TimeSpan.FromSeconds(5),
                _ => TimeSpan.FromSeconds(30)
            };
        }
    }
}

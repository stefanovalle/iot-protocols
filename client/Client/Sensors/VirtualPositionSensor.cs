using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Client.Sensors
{
    class VirtualPositionSensor : PositionSensorInterface, SensorInterface
    {
        public string toJson()
        {
            return "{\"latitude\": " + GetLatitude() + ",\"longitude\": " + GetLongitude() + "}";
        }

        public float GetLatitude()
        {
            var random = new Random();
            return (float) random.Next(100);
        }

        public float GetLongitude()
        {
            var random = new Random();
            return (float)random.Next(100);
        }
    }
}

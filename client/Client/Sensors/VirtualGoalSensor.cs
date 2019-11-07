using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Client.Sensors
{
    class VirtualGoalSensor : GoalSensorInterface, SensorInterface
    {
        public string toJson()
        {
            return "{\"goalDone\": " + GetGoalDone() + "}";
        }

        public void SetGoalDone(bool goalDone)
        {
        }

        public bool GetGoalDone()
        {
            var random = new Random();
            return random.Next(2) == 1;
        }
    }
}

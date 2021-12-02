using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Sensors
{
    interface PositionSensorInterface
    {
        float GetLatitude();

        float GetLongitude();
    }
}

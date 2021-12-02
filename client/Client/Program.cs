using System;
using System.Collections.Generic;
using Client.Sensors;
using Client.Protocols;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            // init sensors
            List<SensorInterface> sensors = new List<SensorInterface>();
            sensors.Add(new VirtualSpeedSensor());

            // define protocol
            //ProtocolInterface protocol = new Http("http://localhost:8011/drones/123");
            ProtocolInterface protocol = new Mqtt("127.0.0.1");

            // send data to server
            while (true)
            {
                foreach (SensorInterface sensor in sensors)
                {
                    var data = sensor.ToJson();

                    protocol.Send(data, sensor.GetSlug());

                    Console.WriteLine("Data sent: " + data);

                    System.Threading.Thread.Sleep(1000);

                }

            }

        }

    }

}

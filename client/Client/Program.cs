using System;
using System.Collections.Generic;
using Client.Sensors;
using System.Net;
using System.IO;
using System.Collections;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            // init sensors
            List<SensorInterface> sensors = new List<SensorInterface>();
            sensors.Add(new VirtualTemperatureSensor());
            sensors.Add(new VirtualPositionSensor());

            while (true)
            {
                foreach (SensorInterface sensor in sensors)
                {
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/cars/AB123CD");
                    httpWebRequest.ContentType = "text/json";
                    httpWebRequest.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(sensor.toJson());
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    Console.Out.WriteLine(httpResponse.StatusCode);

                    System.Threading.Thread.Sleep(1000);

                }

            }

        }

    }

}

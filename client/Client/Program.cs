using System;
using System.Collections.Generic;
using Client.Sensors;
using System.Net;
using System.IO;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                // init sensors
                TemperatureSensorInterface temperatureSensor = new VirtualTemperatureSensor();
                // TODO add more sensors

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/stations/1234");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    decimal temperature = temperatureSensor.getTemperature();
                    string json = "{\"temperature\":\"" + temperature + "\"}";

                    Console.Out.WriteLine("Temperature: " + temperature);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Console.Out.WriteLine(httpResponse.StatusCode);

                System.Threading.Thread.Sleep(1000);

            }

        }

    }

}

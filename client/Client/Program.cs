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
            //ProtocolInterface protocol = new Http("http://localhost:8011/scooters/123");
            
            ProtocolInterface protocol = new Mqtt("localhost", "monopattino/speed");
            /* refactoring necessari alla riga precedente:
             * - spostare secondo parametro su metodo "Send" (che fra l'altro dipende da *cosa* si sta inviando), modificando l'interfaccia per adattarla anche ad altri protocolli
             * - usare stringhe migliori come topic (vedi suggerimenti a lezione)
             */

            // send data to server
            while (true)
            {
                foreach (SensorInterface sensor in sensors)
                {
                    protocol.Send(sensor.toJson());

                    System.Threading.Thread.Sleep(1000);

                }

            }

        }

    }

}

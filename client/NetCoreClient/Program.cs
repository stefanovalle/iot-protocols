using NetCoreClient.Protocols;
using NetCoreClient.Sensors;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualSpeedSensor());

// define protocol
ProtocolInterface protocol = new Http("https://084e-185-122-225-105.ngrok-free.app/cars/123");

// send data to server
while (true)
{
    foreach (ISensorInterface sensor in sensors)
    {
        var sensorValue = sensor.ToJson();

        protocol.Send(sensorValue);

        Console.WriteLine("Data sent: " + sensorValue);

        Thread.Sleep(1000);
    }

}
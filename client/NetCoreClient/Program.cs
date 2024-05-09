using NetCoreClient.Protocols;
using NetCoreClient.Sensors;
using NetCoreClient.Sensors.PositionSensor;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualSpeedSensor());
sensors.Add(new VirtualFuelSensor());
sensors.Add(new VirtualOilTemperatureSensor());
sensors.Add(new VirtualPositionSensor());
sensors.Add(new VirtualTiresPressureSensor());
sensors.Add(new VirtualRPMsSensor());
sensors.Add(new VirtualOdometerSensor());

// define protocol
ProtocolInterface protocol = new Http("http://localhost:8011/cars/123");

// send data to server
while (true)
{
    foreach (ISensorInterface sensor in sensors)
    {
        var sensorValue = sensor.ToJson();

        protocol.Send(sensorValue);

        Console.WriteLine($"Data sent: {sensor.Name()} = {sensorValue}");

        Thread.Sleep(1000);
    }
    Console.WriteLine("");
}
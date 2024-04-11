using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors.PositionSensor;

class VirtualTiresPressureSensor : ITiresPressureSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualTiresPressureSensor()
    {
        Random = new Random();
    }

    public TiresPressure TiresPressure()
    {
        return new TiresPressure(Random.Next(100), Random.Next(100), Random.Next(100), Random.Next(100));
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(TiresPressure());
    }
}
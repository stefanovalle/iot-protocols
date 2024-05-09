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

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public TiresPressure TiresPressure()
    {
        var tirespressure = new TiresPressure(0, 0, 0, 0);

        tirespressure.ValueTireFSX = Random.Next(100);
        tirespressure.ValueTireFDX = Random.Next(100);
        tirespressure.ValueTireRSX = Random.Next(100);
        tirespressure.ValueTireRDX = Random.Next(100);

        return tirespressure;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(TiresPressure());
    }
}
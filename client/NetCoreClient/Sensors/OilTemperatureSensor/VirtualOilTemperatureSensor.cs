using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors;

class VirtualOilTemperatureSensor : IOilTemperatureSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualOilTemperatureSensor()
    {
        Random = new Random();
    }

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public int OilTemperature()
    {
        return new OilTemperature(Random.Next(100)).Value;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(OilTemperature());
    }
}


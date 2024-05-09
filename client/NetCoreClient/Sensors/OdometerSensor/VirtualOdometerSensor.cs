using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors;

class VirtualOdometerSensor : IOdometerSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualOdometerSensor()
    {
        Random = new Random();
    }

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public int Odometer()
    {
        return new Odometer(Random.Next(100)).Value;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Odometer());
    }
}

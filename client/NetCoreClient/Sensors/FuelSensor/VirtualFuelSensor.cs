using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors;

class VirtualFuelSensor : IFuelSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualFuelSensor()
    {
        Random = new Random();
    }

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public int Fuel()
    {
        return new Fuel(Random.Next(100)).Value;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Fuel());
        
    }
}


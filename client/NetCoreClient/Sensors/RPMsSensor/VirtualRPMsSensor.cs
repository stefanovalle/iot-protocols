using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors;

class VirtualRPMsSensor : IRPMsSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualRPMsSensor()
    {
        Random = new Random();
    }

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public int RPMs()
    {
        return new RPMs(Random.Next(100)).Value;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(RPMs());
    }
}

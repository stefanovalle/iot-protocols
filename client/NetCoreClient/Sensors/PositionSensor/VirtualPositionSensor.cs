using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors.PositionSensor;

class VirtualPositionSensor : IPositionSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualPositionSensor()
    {
        Random = new Random();
    }

    public Position Position()
    {
        return new Position(Random.Next(100), Random.Next(100));
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Position());
    }
}
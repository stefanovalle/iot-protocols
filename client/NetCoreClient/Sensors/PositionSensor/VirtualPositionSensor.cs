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

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public Position Position()
    {
        var position = new Position(0, 0);

        position.ValueLat = Random.Next(100);
        position.ValueLon = Random.Next(100);

        return position;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Position());
    }
}
﻿using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors;

class VirtualSpeedSensor : ISpeedSensor, ISensorInterface
{
    private readonly Random Random;

    public VirtualSpeedSensor()
    {
        Random = new Random();
    }

    public string Name()
    {
        string name = this.GetType().Name;
        return name;
    }

    public int Speed()
    {
        return new Speed(Random.Next(100)).Value;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(Speed());
    }
}

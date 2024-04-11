namespace NetCoreClient.ValueObjects;

internal class OilTemperature
{
    public int Value { get; private set; }

    public OilTemperature(int value)
    {
        this.Value = value;
    }
}
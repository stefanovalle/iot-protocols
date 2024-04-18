namespace NetCoreClient.ValueObjects;
internal class OilTemperature
{
    public int Value { get; set; }

    public OilTemperature(int value)
    {
        this.Value = value;
    }
}
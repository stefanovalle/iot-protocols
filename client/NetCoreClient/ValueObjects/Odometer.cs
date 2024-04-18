namespace NetCoreClient.ValueObjects;

internal class Odometer
{
    public int Value { get; set; }

    public Odometer(int value)
    {
        this.Value = value;
    }
}

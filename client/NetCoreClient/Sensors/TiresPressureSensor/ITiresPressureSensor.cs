using NetCoreClient.ValueObjects;

namespace NetCoreClient.Sensors;

interface ITiresPressureSensor
{
    TiresPressure TiresPressure();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.ValueObjects;

internal class TiresPressure
{
    public int ValueTireFSX { get; set; }
    public int ValueTireRSX { get; set; }
    public int ValueTireFDX { get; set; }
    public int ValueTireRDX { get; set; }

    public TiresPressure(int valueTireFSX, int valueTireRSX, int valueTireFDX, int valueTireRDX)
    {
        valueTireFSX = ValueTireFSX;
        valueTireRSX = ValueTireRSX;
        valueTireRDX = ValueTireRDX;
        valueTireFDX = ValueTireFDX;
    }
}

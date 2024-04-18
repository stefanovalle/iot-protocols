using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.ValueObjects;

internal class Position
{
    public int ValueLat { get; set; }
    public int ValueLon { get; set; }

    public Position(int valueLat, int valueLon)
    {
        valueLat = ValueLat;
        valueLon = ValueLon;
    }
}

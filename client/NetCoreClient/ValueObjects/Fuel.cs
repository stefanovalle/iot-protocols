﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreClient.ValueObjects;

internal class Fuel
{
    public int Value { get; set; }

    public Fuel(int value)
    {
        this.Value = value;
    }
}

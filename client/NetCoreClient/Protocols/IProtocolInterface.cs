<<<<<<< HEAD:client/NetCoreClient/Protocols/ProtocolInterface.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreClient.Protocols
{
    interface ProtocolInterface
    {
        void Send(string data);
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreClient.Protocols
{
    interface IProtocolInterface
    {
        void Send(string data, string sensor);
    }
}
>>>>>>> 3bfccb211c76d36433611b06e74629564d577401:client/NetCoreClient/Protocols/IProtocolInterface.cs

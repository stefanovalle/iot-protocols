<<<<<<< HEAD:client/NetCoreClient/Sensors/Base/ISensorInterface.cs
﻿namespace NetCoreClient.Sensors
{
    interface ISensorInterface
    {
        string ToJson();
        string Name();
    }
}
=======
﻿namespace NetCoreClient.Sensors
{
    interface ISensorInterface
    {
        string ToJson();

        string GetSlug();
    }
}
>>>>>>> 3bfccb211c76d36433611b06e74629564d577401:client/NetCoreClient/Sensors/ISensorInterface.cs

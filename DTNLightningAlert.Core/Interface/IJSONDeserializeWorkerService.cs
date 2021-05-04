using System;
using System.Collections.Generic;
using System.Text;

namespace DTNLightningAlert.Core.Interface
{
    public interface IJSONDeserializeWorkerService<T>
    {
        List<T> DeserializeJsonFile();
    }
}

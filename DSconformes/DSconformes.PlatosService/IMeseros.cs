using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSconformes.PlatosService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMeseros" in both code and config file together.
    [ServiceContract]
    public interface IMeseros
    {
        [OperationContract]
        void DoWork();
    }
}

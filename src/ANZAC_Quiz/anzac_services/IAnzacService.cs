using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace anzac_services
{
    [ServiceContract]
    interface IAnzacService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}

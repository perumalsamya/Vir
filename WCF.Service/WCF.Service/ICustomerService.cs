using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF.Service
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        IEnumerable<Customer> GetByKey(string id);

        [OperationContract]
        string Save(string name, string id, string age, string address, string description);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfProject1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int C2f(int c);

        [OperationContract]
        int F2c(int f);

        [OperationContract]
        string sortNums(string nums);

        [OperationContract]
        string encrypt(string text);

        [OperationContract]
        string decrypt(string text);
    }
}

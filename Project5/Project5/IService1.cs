using System.Collections.Generic;
using System.ServiceModel;

namespace Project4
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<string> SearchXmlContent(string xmlUrl, string searchKey);

        [OperationContract]
        string VerifyXmlWithXsd(string xmlUrl, string xsdUrl);
    }
}

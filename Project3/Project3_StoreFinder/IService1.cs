using System.ServiceModel;

namespace Project3_StoreFinder
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string FindClosestStore(string zipCode, string storeName);
    }
}

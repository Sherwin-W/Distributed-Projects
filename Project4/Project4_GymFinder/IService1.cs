using System.ServiceModel;

namespace Project4_GymFinder
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string FindClosestGyms(string zipCode);
    }
}

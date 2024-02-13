using System.ServiceModel;

namespace Project3_StoreFinder
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string FindClosestStore(string zipCode, string storeName);

        [OperationContract]
        string FindClosestGyms(string zipCode);

        [OperationContract]
        string GetStockOpen(string symbol, int year, int month, int day);

        [OperationContract]
        string FindRecipes(string ingredients);
    }
}

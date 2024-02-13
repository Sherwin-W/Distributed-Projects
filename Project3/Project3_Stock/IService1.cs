using System.ServiceModel;

namespace Project3_Stock
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetStockOpen(string symbol, int year, int month, int day);
    }
}

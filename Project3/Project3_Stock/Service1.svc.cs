using Newtonsoft.Json.Linq;
using RestSharp;

namespace Project3_Stock
{
    public class Service1 : IService1
    {
        public string GetStockOpen(string symbol, int year, int month, int day)
        {
            string apiKey = "iGSXXN3yrHChq402k12oCMrWpibmoCVr";

            //construct the date string in the format "YYYY-MM-DD"
            string date = $"{year:D4}-{month:D2}-{day:D2}";

            string apiUrl = $"https://api.polygon.io/v1/open-close/{symbol}/{date}?adjusted=true&apiKey={apiKey}";

            var client = new RestClient(apiUrl);
            var request = new RestRequest();
            var response = client.Get(request);

            var json = JObject.Parse(response.Content);

            return json["open"].ToString();
        }
    }
}

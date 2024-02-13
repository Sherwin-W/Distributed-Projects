using System;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Project3_StoreFinder
{ 
    public class Service1 : IService1
    {
        public string FindClosestStore(string zipCode, string storeName)
        {
            //construct api url for zipcode to lat-long coordinates
            string apiKey = "AIzaSyCmzwcwd5b0LHRsDgs0wGYton1zXsizaJg";

            string urlZip = $"https://maps.googleapis.com/maps/api/geocode/json?address={zipCode}&key={apiKey}";

            var client1 = new RestClient(urlZip);
            var request1 = new RestRequest();
            var response1 = client1.Get(request1);
            var result1 = JObject.Parse(response1.Content);

            double targetLatitude = double.Parse(result1["results"][0]["geometry"]["location"]["lat"].ToString());
            double targetLongitude = double.Parse(result1["results"][0]["geometry"]["location"]["lng"].ToString());

            //construct api url for finding stores named "storename"
            //32187 meters is 20 miles
            string urlStoreSearch = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?keyword={storeName}&location={targetLatitude},{targetLongitude}&radius=32187&type=store&key={apiKey}";

            var client2 = new RestClient(urlStoreSearch);

            var request2 = new RestRequest();

            var response2 = client2.Get(request2);

            var result2 = JObject.Parse(response2.Content);

            //store search results as an array
            var listStores = result2["results"] as JArray;

            string closestStore = "";
            double storeDistance = Double.MaxValue;

            //iterate through array to find the store with closest distance to our zipcode
            if (listStores != null)
            {
                for (int i = 0; i < listStores.Count; i++)
                {
                    var store = listStores[i];
                    double storeLatitude = double.Parse(store["geometry"]["location"]["lat"].ToString());
                    double storeLongitude = double.Parse(store["geometry"]["location"]["lng"].ToString());
                    double distance = CalculateDistance(targetLatitude, targetLongitude, storeLatitude, storeLongitude);

                    if (distance < storeDistance)
                    {
                        closestStore = store["vicinity"].ToString();
                        storeDistance = distance;
                    }
                }
                return closestStore;
            }
            else
            {
                return "No stores found within 20 miles";
            }
        }
        
        //method for finding distance between two sets of coordinates
        static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double earthRadius = 6371; //radius of the Earth in kilometers

            double dLat = DegreeToRadian(lat2 - lat1);
            double dLon = DegreeToRadian(lon2 - lon1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = earthRadius * c;

            return distance;
        }

        static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelInsurance
{
    public class GetData
    {
        public TravelResponseDTO getInsuranceData()
        {
            var client = new RestClient("https://api.tmsandbox.co.nz");

            var categoriesrequest = new RestRequest("/v1/Categories/6327/Details.json", Method.GET);
            categoriesrequest.AddHeader("Accept", "application/json");
            categoriesrequest.AddQueryParameter("catalogue", "false");
            categoriesrequest.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(categoriesrequest);
            var responseContent = response.Content;
            var travelData = JsonConvert.DeserializeObject<TravelResponseDTO>(responseContent);
            return travelData;

        }
    }
}

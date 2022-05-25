using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft;
namespace helper_classes
{
    public class ApiConnector
    {
        ClientFactory clientFactory;
        public ApiConnector(ClientFactory clientFactory)
        {
            this.clientFactory = new ClientFactory();
        }

        public async Task<CatFacts> GetCatFact()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://catfact.ninja/fact");

            var client = this.clientFactory.CreateHttpClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                //ChuckNorrisTest joke = await response.Content.ReadFromJsonAsync<ChuckNorrisTest>();
                CatFacts catFact = await response.Content.ReadAsAsync<CatFacts>();
                return catFact;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<Root> GetRandomName(bool fullName, string gender)
        {
            // Default request

            var request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/");
            switch (gender)
            {
                case "male":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=male&nat=DE");
                    break;
                case "female":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=female&nat=DE");
                    break;
            }
            var client = this.clientFactory.CreateHttpClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                //ChuckNorrisTest joke = await response.Content.ReadFromJsonAsync<ChuckNorrisTest>();
                Root fullNameObj = await response.Content.ReadAsAsync<Root>();
                return fullNameObj;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

    }
}

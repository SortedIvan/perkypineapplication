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
                Root fullNameObj = await response.Content.ReadAsAsync<Root>();
                return fullNameObj;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<Root> GetRandomSpaceName(string gender)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/");
            switch (gender)
            {
                case "male":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=male&nat=FI");
                    break;
                case "female":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=female&nat=FI");
                    break;
            }
            var client = this.clientFactory.CreateHttpClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Root fullNameObj = await response.Content.ReadAsAsync<Root>();
                return fullNameObj;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<Root> GetRandomSciFiName(string gender)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/");
            switch (gender)
            {
                case "male":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=male&nat=NO");
                    break;
                case "female":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=female&nat=NO");
                    break;
            }
            var client = this.clientFactory.CreateHttpClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Root fullNameObj = await response.Content.ReadAsAsync<Root>();
                return fullNameObj;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<Root> GetRandomFantasyName(string gender)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/");
            switch (gender)
            {
                case "male":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=male&nat=GB");
                    break;
                case "female":
                    request = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api/?inc=name&gender=female&nat=GB");
                    break;
            }
            var client = this.clientFactory.CreateHttpClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace helper_classes
{
    public class ClientFactory
    {
        public ClientFactory()
        {

        }

        public HttpClient CreateHttpClient()
        {
            return new HttpClient();
        }

        private string MimoNigga()
        {
            return "mimo retard";
        }
    }
}

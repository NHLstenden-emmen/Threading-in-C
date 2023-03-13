using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Threading_in_C.OpenFiveApi
{
    public class OpenFiveApiRequest
    {
        private readonly OpenFiveApiUrlBuilder urlBuilder;

        public OpenFiveApiRequest()
        {
            urlBuilder = new OpenFiveApiUrlBuilder();
        }

        public string GetEndpointUrl(string endpoint)
        {
            return urlBuilder.returnOpenFiveApiURl(endpoint);
        }

        public string MakeOpenFiveApiRequest(string endpoint, int? page = null, int? cr = null)
        {
            string url = GetEndpointUrl(endpoint);

            // Checks if page parameter is given
            if (page != null && page != null)
            {
                url += $"?page={page}";
            }

            if (endpoint == "monsters" && cr != null)
            {
                int crConstrained = Math.Min(Math.Max((int)cr, 0), 30);
                url += $"?challenge_rating={crConstrained}";
            }


            using (var client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public string MakeOpenFiveApiRequest(string endpoint, int? page = null)
        {
            string url = GetEndpointUrl(endpoint);

            // Checks if page parameter is given
            if (page != null && page != 0)
            {
                url += $"?page={page}";
            }

            using (var client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }

    }
}

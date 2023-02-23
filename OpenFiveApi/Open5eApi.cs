using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.API
{
    public class Open5eApiClient
    {
        private readonly string apiUrl = "https://api.open5e.com/monsters/";

        public async Task<string> SearchMonstersAsync(string searchQuery)
        {
            using (var clientOpen = new HttpClient())
            {
                var url = apiUrl + "?search=" + searchQuery;
                var response = await clientOpen.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException("API call failed with status code " + response.StatusCode);
                }
            }
        }
    }

    class Programs
    {
        static async Task Main(string[] args)
        {
            var clientOpen = new Open5eApiClient();
            var response = await clientOpen.SearchMonstersAsync("fir"); //haalt alle monsters met fire op
            Console.WriteLine(response);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.APICALL
{
    public class Dnd5eApiClient
    {
        private readonly string apiUrl = "https://www.dnd5eapi.co/api/";

        public async Task<string> GetAbilityScoreAsync(string abilityScore)
        {
            using (var client = new HttpClient())
            {
                var url = apiUrl + "ability-scores/" + abilityScore; // wil je iets anders bijvoorbeeld class moet je classes/barbarian/ 
                var response = await client.GetAsync(url);
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
        class Program
        {
            static async Task Main(string[] args)
            {
                var client = new Dnd5eApiClient();
                var response = await client.GetAbilityScoreAsync("int"); //afkorting van karakter specs invullen int, str, dex, etc
                Console.WriteLine(response);
            }
        }
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;

class API
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://api.open5e.com/search/?text=fire"),
        };
        request.Headers.Add("Authorization", "Bearer ACCESS_TOKEN");

        using var response = await client.SendAsync(request);
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
}
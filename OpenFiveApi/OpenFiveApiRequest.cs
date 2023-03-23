using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace Threading_in_C.OpenFiveApi
{
    public class OpenFiveApiRequest
    {
        public static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.Replace("bin\\Debug", "Datasets\\DungeonDB.mdf;Integrated Security=True"));
        private readonly OpenFiveApiUrlBuilder urlBuilder;

        public OpenFiveApiRequest()
        {
            urlBuilder = new OpenFiveApiUrlBuilder();
        }

        public string GetEndpointUrl(string endpoint)
        {
            return urlBuilder.returnOpenFiveApiURl(endpoint);
        }

        public string MakeOpenFiveApiRequest(string endpoint, int? page = null, int? cr = null, string rarity = null)
        {
            string url = GetEndpointUrl(endpoint);

            // Checks if page parameter is given
            if (page != null)
            {
                url += $"?page={page}";
            }

            if (endpoint == "monsters" && cr.HasValue)
            {
                int crConstrained = Math.Min(Math.Max((int)cr, 0), 30);
                url += $"?challenge_rating={crConstrained}";
            }

            if (endpoint == "magicitems" && rarity != null)
            {
                url += $"?rarity={rarity}";
            }

            using (var client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}

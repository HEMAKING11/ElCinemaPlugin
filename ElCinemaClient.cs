using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ElCinemaPlugin
{
    public class ElCinemaClient
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> GetActorInfo(string actorName)
        {
            var url = $"https://api.elcinema.com/actor?name={actorName}";
            var response = await client.GetStringAsync(url);
            var json = JObject.Parse(response);

            // Parse the JSON data as needed
            var actorInfo = json["data"]["actor"].ToString();

            return actorInfo;
        }
    }
}

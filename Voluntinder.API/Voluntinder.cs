using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Voluntinder.API.Models;
using Voluntinder.API.Requests;

namespace Voluntinder.API
{
    public class Voluntinder
    {
        public Voluntinder(string apiKey)
        {
            ApiRequest.ApiKey = apiKey;
        }

        public async Task<Profile> GetProfileAsync()
        {
            string result = await ApiRequest.MakeGetRequest("/profile");
            return JObject.Parse(result).ToObject<Profile>();
        }
    }
}

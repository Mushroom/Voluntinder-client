using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Voluntinder.API.Requests
{
    internal class ApiRequest
    {
        internal static String ApiKey;

        private const String BaseApiEndpoint = "http://104.225.223.6:8080/api";
        private static HttpClient Client;

        internal static async Task<String> MakeGetRequest(string endpoint)
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, BaseApiEndpoint + endpoint);
            requestMessage.Headers.Add("Authorization", ApiKey);

            HttpResponseMessage responseMessage = await Client.SendAsync(requestMessage);

            Debug.WriteLine("test!");

            if (responseMessage.IsSuccessStatusCode)
            {
                return await responseMessage.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"{(int)responseMessage.StatusCode} {responseMessage.ReasonPhrase}: {await responseMessage.Content.ReadAsStringAsync()}");
            }
        }

        internal static async Task<HttpResponseMessage> MakePostRequest(string endpoint, string bodyContent)
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, BaseApiEndpoint + endpoint);

            requestMessage.Headers.Add("Accept", "application/json");

            requestMessage.Content = new StringContent(bodyContent, Encoding.UTF8, "application/x-www-form-urlencoded");

            HttpResponseMessage responseMessage = await Client.SendAsync(requestMessage);

            if (responseMessage.IsSuccessStatusCode)
            {
                return responseMessage;
            }
            else
            {
                throw new Exception(
                    $"{(int)responseMessage.StatusCode} {responseMessage.ReasonPhrase}: {await responseMessage.Content.ReadAsStringAsync()}");
            }
        }
    }
}

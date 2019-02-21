using Atlas.Sms.Sdk.Constants;
using System;
using System.Text;
using System.Net.Http;

namespace Atlas.Sms.Sdk
{
    public static class HttpRequestSetup {
        public static HttpClient CreateClient(String accesKey, String secretKey) {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(BaseConstants.AtlasSmsBaseEndPoint)
            };

            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Add("content-type", BaseConstants.ContentTypeHeaderJson);

            client.DefaultRequestHeaders.Add("cache-control", "no-cache");

            var keysArray = new String[]{accesKey, secretKey};

            var byteArray = Encoding.ASCII.GetBytes(String.Join(":", keysArray));

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            return client;
        }
    }
}

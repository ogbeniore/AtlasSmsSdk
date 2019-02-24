using Newtonsoft.Json;
using Atlas.Sms.Sdk.Constants;
using Atlas.Sms.Sdk.Models;
using Atlas.Sms.Sdk.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;


namespace Atlas.Sms.Sdk.SendSms
{
    public class Sms : ISendSms
    {
        private string _accessKey;
        private string _secretKey;

        public Sms(String accessKey, String secretKey)
        {
            this._accessKey = accessKey;
            this._secretKey = secretKey;
        }

        /// <summary>
        /// Sends body parameters to sms sending url
        /// </summary>
        /// <param name="to"></param>
        /// <param name="sender"></param>
        /// <param name="content"></param>
        /// 

        public async Task<SendSmsResponseModel> SendMessage(String to, String sender, String content)
        {
            var client = HttpRequestSetup.CreateClient(this._accessKey, this._secretKey);

            var bodyKeyValues = new List<KeyValuePair<string, string>>();

            bodyKeyValues.Add(new KeyValuePair<string, string>("to", to));
            bodyKeyValues.Add(new KeyValuePair<string, string>("sender", sender));
            bodyKeyValues.Add(new KeyValuePair<string, string>("content", content));

            var formContent = new FormUrlEncodedContent(bodyKeyValues);

            var response = await client.PostAsync(BaseConstants.AtlasSmsBaseEndPoint, formContent);

            HttpContent responseContent = response.Content;

            string result = await responseContent.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SendSmsResponseModel>(result);
        }
    }
}

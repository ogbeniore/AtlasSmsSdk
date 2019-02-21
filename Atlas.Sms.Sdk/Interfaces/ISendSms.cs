using System;
using System.Collections.Generic;
using System.Text;
using Atlas.Sms.Sdk.Models;
using System.Threading.Tasks;

namespace Atlas.Sms.Sdk.Interfaces
{
    interface ISendSms
    {
        Task<SendSmsResponseModel> SendMessage(String to, String sender, String content);
    }
}

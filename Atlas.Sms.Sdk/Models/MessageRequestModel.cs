using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Sms.Sdk.Models
{
    public class MessageRequestModel
    {
        public String sender { get; set; }
        public String to { get; set; }
        public String content { get; set; }
    }
}

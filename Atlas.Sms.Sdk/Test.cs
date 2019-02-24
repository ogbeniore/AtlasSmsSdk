using System;
using Atlas.Sms.Sdk.SendSms;
using Atlas.Sms.Sdk;

public class Test
{
	public Test()
	{
        var sms = new Sms("ii8j2gzfIjRb0k7tlKu1nypRwcEDg4csu6wfjq0u1d4mRNLBInRocw==", "6cpJnzVTAT");

        var response = sms.SendMessage("+250780102786", "+250780102786", "this is a test message");

    }
}

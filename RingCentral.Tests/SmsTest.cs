using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class SmsTest
{
    [Fact]
    public async void SendSms()
    {
        var rc = await ReusableRestClient.GetInstance();

        var messageInfo = await rc.Restapi().Account().Extension().Sms().Post(new CreateSMSMessage
        {
            from = new MessageStoreCallerInfoRequest
            {
                phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_SENDER")
            },
            to = new[]
            {
                new MessageStoreCallerInfoRequest
                {
                    phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                }
            },
            text = "Hello world"
        });
        Assert.Equal("SMS", messageInfo.type);
        Assert.Equal("Outbound", messageInfo.direction);
        Assert.Equal("Read", messageInfo.readStatus); // because it is an outbound SMS
    }

    [Fact]
    public async void SendSmsComplicated()
    {
        var rc = await ReusableRestClient.GetInstance();
        var httpContent = new StringContent(JsonConvert.SerializeObject(new
        {
            from = new
            {
                phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_SENDER")
            },
            to = new[]
            {
                new
                {
                    phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                }
            },
            text = "Hello world"
        }), Encoding.UTF8, "application/json");
        var responseMessage = await rc.Post("/restapi/v1.0/account/~/extension/~/sms", httpContent);
        Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
        var responseString = await responseMessage.Content.ReadAsStringAsync();
        Assert.Contains("SMS", responseString);
        Assert.Contains("Outbound", responseString);
        Assert.Contains("readStatus", responseString);
    }
}
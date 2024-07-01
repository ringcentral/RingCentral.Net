using System;
using System.IO;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class MmsTest
{
    [Fact]
    public async void SendMms()
    {
        var rc = await ReusableRestClient.GetInstance();
        var extension = rc.Restapi().Account().Extension();
        var attachments = new[]
        {
            new Attachment
            {
                filename = "rc.png",
                contentType = "image/png",
                content = File.ReadAllBytes("rc.png")
            }
        };

        var messageInfo = await extension.Mms().Post(new CreateMMSMessage
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
            text = "Hello world again",
            attachments = attachments
        });

        Assert.NotNull(messageInfo);
        Assert.Equal("SMS", messageInfo.type);
    }
}
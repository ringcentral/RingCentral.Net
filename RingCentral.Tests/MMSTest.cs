using System;
using System.IO;
using Xunit;

namespace RingCentral.Tests
{
    public class MmsTest
    {
        [Fact]
        public async void SendMms()
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                var extension = rc.Restapi().Account().Extension();
                var attachments = new[]
                {
                    new Attachment
                    {
                        fileName = "rc.png",
                        contentType = "image/png",
                        bytes = File.ReadAllBytes("rc.png")
                    }
                };

                var messageInfo = await extension.Sms().Post(new CreateSMSMessage
                {
                    from = new MessageStoreCallerInfoRequest
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                    },
                    to = new[]
                    {
                        new MessageStoreCallerInfoRequest
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                        }
                    },
                    text = "Hello world again"
                }, attachments);

                Assert.NotNull(messageInfo);
                Assert.Equal("SMS", messageInfo.type);
            }
        }
    }
}
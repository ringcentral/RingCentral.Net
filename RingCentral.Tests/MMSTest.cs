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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
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

                // comment out, because sandbox doesn't support sms/mms any more
                // var messageInfo = await extension.Mms().Post(new CreateMMSMessage
                // {
                //     from = new MessageStoreCallerInfoRequest
                //     {
                //         phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                //     },
                //     to = new[]
                //     {
                //         new MessageStoreCallerInfoRequest
                //         {
                //             phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                //         }
                //     },
                //     text = "Hello world again",
                //     attachments = attachments
                // });
                //
                // Assert.NotNull(messageInfo);
                // Assert.Equal("SMS", messageInfo.type);
            }
        }
    }
}
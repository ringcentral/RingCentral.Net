using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace RingCentral.Tests
{
    public class BinaryTest
    {
        [Fact]
        public async void ProfileImage()
        {
            var bytes = File.ReadAllBytes("rc.png");
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

                var bytes2 = await extension.ProfileImage().Post(new CreateUserProfileImageRequest
                {
                    image = new Attachment
                    {
                        content = bytes,
                        filename = "rc.png",
                        contentType = "image/png"
                    }
                });
                Assert.NotNull(bytes2);
                Assert.Empty(bytes2);

                var bytes3 = await extension.ProfileImage().Put(new UpdateUserProfileImageRequest
                {
                    image = new Attachment
                    {
                        content = bytes,
                        filename = "rc.png",
                        contentType = "image/png"
                    }
                });
                Assert.NotNull(bytes3);
                Assert.Empty(bytes3);

                var bytes4 = await extension.ProfileImage().List(); // todo: this name should be Get
                Assert.NotNull(bytes4);
                Assert.Equal(bytes, bytes4);

                var bytes5 = await extension.ProfileImage("90x90").Get();
                Assert.NotNull(bytes5);
            }
        }

        [Fact]
        public async void MessageContent()
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

                var response = await extension.MessageStore()
                    .List(new ListMessagesParameters
                    {
                        dateFrom = DateTime.UtcNow.AddDays(-120).ToString("o"),
                        perPage = 300
                    });
                var messages = response.records;

                // sms
                var message = messages
                    .First(m => m.type == "SMS" && m.attachments != null && m.attachments.Length > 0);
                var content = await extension.MessageStore(message.id.ToString())
                    .Content(message.attachments[0].id.ToString()).Get();
                var str = Encoding.UTF8.GetString(content);
                Assert.NotNull(str);
                Assert.True(str.Length > 0);

                // fax
                message = messages.LastOrDefault(m =>
                    m.type == "Fax" && m.messageStatus == "Delivered" &&
                    m.attachments != null &&
                    m.attachments.Length > 0);
                if (message == null) return;

                //                content = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
                content = await rc.Get<byte[]>(message.attachments[0].uri);
                Assert.NotNull(content);
                Assert.True(content.Length > 0);
                File.WriteAllBytes("test.pdf", content);
            }
        }


        [Fact]
        public async void RecordingContent()
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
                var account = rc.Restapi().Account();

                // List call Logs
                var queryParams = new ReadCompanyCallLogParameters
                {
                    type = new[] {"Voice"},
                    view = "Detailed",
                    dateFrom = DateTime.UtcNow.AddDays(-365).ToString("o"),
                    withRecording = true,
                    perPage = 10
                };
                var callLogs = await account.CallLog().List(queryParams);
                if (callLogs.records.Length > 0)
                {
                    // download a call recording
                    var callLog = callLogs.records[0];
                    if (callLog.recording != null)
                    {
                        var content = await account.Recording(callLog.recording.id).Content().Get();
                        Assert.NotNull(content);
                        Assert.True(content.Length > 0);
                        File.WriteAllBytes("test.wav", content);
                    }
                }
            }
        }
    }
}
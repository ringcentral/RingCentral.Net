using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class BinaryTest
    {
        [Fact]
        public async void ProfileImage()
        {
            var bytes = System.IO.File.ReadAllBytes("rc.png");
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

                var bytes2 = await extension.ProfileImage().Post(new UploadProfileImageRequest
                {
                    image = new Attachment
                    {
                        bytes = bytes,
                        fileName = "rc.png",
                        contentType = "image/png"
                    }
                });
                Assert.NotNull(bytes2);
                Assert.Empty(bytes2);

                var bytes3 = await extension.ProfileImage().Put(new UpdateProfileImageRequest
                {
                    image = new Attachment
                    {
                        bytes = bytes,
                        fileName = "rc.png",
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
                        dateFrom = DateTime.UtcNow.AddDays(-30).ToString("o"),
                        perPage = 500
                    });
                var messages = response.records;

                // sms
                var message = messages
                    .First(m => m.type == "SMS" && m.attachments != null && m.attachments.Length > 0);
                var content = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
                var str = System.Text.Encoding.UTF8.GetString(content);
                Assert.NotNull(str);
                Assert.True(str.Length > 0);

                // fax
                message = messages.Last(m => m.type == "Fax" && m.messageStatus != "SendingFailed" &&
                                             m.attachments != null &&
                                             m.attachments.Length > 0);
//                content = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
                content = await rc.Get<byte[]>(message.attachments[0].uri);
                Assert.NotNull(content);
                Assert.True(content.Length > 0);
                System.IO.File.WriteAllBytes("test.pdf", content);
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
                var queryParams = new LoadCompanyCallLogParameters
                {
                    type = new[] {"Voice"},
                    view = "Detailed",
                    dateFrom = DateTime.UtcNow.AddDays(-365).ToString("o"),
                    withRecording = true,
                    perPage = 10,
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
                        System.IO.File.WriteAllBytes("test.wav", content);
                    }
                }
            }
        }
    }
}
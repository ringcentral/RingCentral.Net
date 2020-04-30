using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class CancellationTest
    {
        [Fact]
        public async void CancelAfter()
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

                var sendFaxMessageRequest = new CreateFaxMessageRequest
                {
                    to = new[]
                    {
                        new MessageStoreCalleeInfoRequest
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER"),
                            name = "The Receiver"
                        }
                    },
                    attachments = new[]
                    {
                        new Attachment
                        {
                            fileName = "rc.png",
                            bytes = File.ReadAllBytes("./rc.png")
                        },
                        new Attachment
                        {
                            fileName = "glip.png",
                            bytes = File.ReadAllBytes("./glip.png")
                        },
                        new Attachment
                        {
                            fileName = "hello.txt",
                            bytes = Encoding.UTF8.GetBytes("Hello 888")
                        }
                    }
                };
                CancellationTokenSource source = new CancellationTokenSource();
                CancellationToken token = source.Token;
                source.CancelAfter(10); // impossible to send a fax within 10ms
                var taskCanceledException = false;
                try
                {
                    var r = await rc.Restapi().Account().Extension().Fax().Post(sendFaxMessageRequest, token);
                }
                catch (TaskCanceledException)
                {
                    taskCanceledException = true;
                }
                finally
                {
                    Assert.True(taskCanceledException);
                }
            }
        }
    }
}
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
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                var sendFaxMessageRequest = new CreateFaxMessageRequest
                {
                    to = new[]
                    {
                        new FaxReceiver
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER"),
                            name = "The Receiver"
                        }
                    },
                    attachments = new[]
                    {
                        new Attachment
                        {
                            filename = "rc.png",
                            content = File.ReadAllBytes("./rc.png")
                        },
                        new Attachment
                        {
                            filename = "glip.png",
                            content = File.ReadAllBytes("./glip.png")
                        },
                        new Attachment
                        {
                            filename = "hello.txt",
                            content = Encoding.UTF8.GetBytes("Hello 888")
                        }
                    }
                };
                var source = new CancellationTokenSource();
                var token = source.Token;
                source.CancelAfter(10); // impossible to send a fax within 10ms
                var taskCanceledException = false;
                try
                {
                    await rc.Restapi().Account().Extension().Fax().Post(sendFaxMessageRequest, new RestRequestConfig
                    {
                        cancellationToken = token
                    });
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
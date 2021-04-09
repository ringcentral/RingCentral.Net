using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class FaxTest
    {
        [Fact]
        public async void SendFax()
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
                var r = await rc.Restapi().Account().Extension().Fax().Post(sendFaxMessageRequest);
                Assert.Equal("High", r.faxResolution);
            }
        }

        [Fact]
        public async void SendFaxComplicated()
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

                var requestObj = new CreateFaxMessageRequest
                {
                    to = new[]
                    {
                        new MessageStoreCalleeInfoRequest
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                        }
                    },
                    faxResolution = "Low",
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
                var multipartFormDataContent = new MultipartFormDataContent();
                var pairs = Utils.GetPairs(requestObj);
                var dict = pairs.Where(p => !(p.value is Attachment || p.value is IEnumerable<Attachment>))
                    .ToDictionary(p => p.name, p => p.value);
                var stringContent =
                    new StringContent(JsonConvert.SerializeObject(dict), Encoding.UTF8, "application/json");
                multipartFormDataContent.Add(stringContent, "request.json");
                pairs.Where(p => p.value is Attachment || p.value is IEnumerable<Attachment>).ToList().ForEach(p =>
                {
                    var attachments = p.value;
                    if (!(attachments is IEnumerable<Attachment>)) attachments = new[] {attachments};

                    (attachments as IEnumerable<Attachment>).ToList().ForEach(attachment =>
                    {
                        var content = new ByteArrayContent(attachment.content);
                        multipartFormDataContent.Add(content, attachment.filename, attachment.filename);
                    });
                });

                var responseMessage =
                    await rc.Post("/restapi/v1.0/account/~/extension/~/fax", multipartFormDataContent);
                Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
                var responseString = await responseMessage.Content.ReadAsStringAsync();
                Assert.Contains("Fax", responseString);
                Assert.Contains("Outbound", responseString);
                Assert.Contains("faxResolution", responseString);
            }
        }

        [Fact]
        public async void SendFaxMoreComplicated()
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

                var multipartFormDataContent = new MultipartFormDataContent();

                // specify fax sending options including "to"
                var stringContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    to = new[]
                    {
                        new
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                        }
                    }
                }), Encoding.UTF8, "application/json");
                multipartFormDataContent.Add(stringContent, "request.json");

                // append a text file
                var stringContent2 = new StringContent("Hello", Encoding.UTF8, "text/plain");
                multipartFormDataContent.Add(stringContent2, "hello.txt");

                // another way to append a text file
                var plainFileStreamContent = new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes("World")));
                plainFileStreamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "world.txt",
                    FileName = "world.txt"
                };
                multipartFormDataContent.Add(plainFileStreamContent);

                // append an image file
                var streamContent = new StreamContent(new FileStream("./rc.png", FileMode.Open));
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "rc.png",
                    FileName = "rc.png"
                };
                multipartFormDataContent.Add(streamContent);

                // append another image file
                var streamContent2 = new StreamContent(new FileStream("./glip.png", FileMode.Open));
                streamContent2.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "glip.png",
                    FileName = "glip.png"
                };
                multipartFormDataContent.Add(streamContent2);

                var responseMessage =
                    await rc.Post("/restapi/v1.0/account/~/extension/~/fax", multipartFormDataContent);
                Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
                var responseString = await responseMessage.Content.ReadAsStringAsync();
                Assert.Contains("Fax", responseString);
                Assert.Contains("Outbound", responseString);
                Assert.Contains("faxResolution", responseString);
            }
        }
    }
}
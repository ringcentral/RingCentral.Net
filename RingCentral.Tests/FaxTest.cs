using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class FaxTest
    {
        [Fact]
        public async Task SendFax()
        {
            var env = Environment.GetEnvironmentVariables();
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

                MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();

                // specify fax sending options including "to"
                var stringContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    to = new[]
                    {
                        new
                        {
                            phoneNumber = env["RINGCENTRAL_RECEIVER"] as string
//                            phoneNumber = "16506417402"
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
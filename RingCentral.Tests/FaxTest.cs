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
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_SERVER_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );

                MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();

                var stringContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    to = new[]
                    {
                        new MessageStoreCallerInfoRequest
                        {
                            phoneNumber = env["RINGCENTRAL_RECEIVER"] as string
                        }
                    },
                }), Encoding.UTF8, "application/json");
                multipartFormDataContent.Add(stringContent, "request.json");

                var stream = new FileStream("./rc.png", FileMode.Open);
                var streamContent = new StreamContent(stream);
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "rc.png",
                    FileName = "rc.png"
                };
                multipartFormDataContent.Add(streamContent, "attachment");

                var responseMessage =
                    await rc.Post("/restapi/v1.0/account/~/extension/~/fax", multipartFormDataContent);
                Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
//                var responseString = await responseMessage.Content.ReadAsStringAsync();
//                Assert.Contains("SMS", responseString);
//                Assert.Contains("Outbound", responseString);
//                Assert.Contains("readStatus", responseString);
            }
        }
    }
}
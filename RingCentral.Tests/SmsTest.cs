using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class SmsTest
    {
        [Fact]
        public async Task SendSms()
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
                var httpContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    from = new MessageStoreCallerInfoRequest
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                    },
                    to = new[]
                    {
                        new MessageStoreCallerInfoRequest
                        {
                            phoneNumber = env["RINGCENTRAL_RECEIVER"] as string
                        }
                    },
                    text = "Hello world"
                }), Encoding.UTF8, "application/json");
                var responseMessage = await rc.Post("/restapi/v1.0/account/~/extension/~/sms", httpContent);
                Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);
                var responseString = await responseMessage.Content.ReadAsStringAsync();
                Assert.Contains("SMS", responseString);
                Assert.Contains("Outbound", responseString);
                Assert.Contains("readStatus", responseString);
            }
        }
    }
}
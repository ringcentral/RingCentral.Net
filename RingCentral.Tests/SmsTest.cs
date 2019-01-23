using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RingCentral;
using Xunit;

namespace RingCentral.Tests
{
    public class SmsTest
    {
        [Fact]
        public async Task SendSms()
        {
            var env = Environment.GetEnvironmentVariables();
            var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_SERVER_URL"] as string
            );
            await rc.Authorize(
                env["RINGCENTRAL_USERNAME"] as string,
                env["RINGCENTRAL_EXTENSION"] as string,
                env["RINGCENTRAL_PASSWORD"] as string
            );
            var httpContent = new StringContent(JsonConvert.SerializeObject(new CreateSMSMessage
            {
                from = new MessageStoreCallerInfoRequest
                {
                    phoneNumber = env["RINGCENTRAL_USERNAME"] as string
                },
                to = new[] {
                    new MessageStoreCallerInfoRequest {
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
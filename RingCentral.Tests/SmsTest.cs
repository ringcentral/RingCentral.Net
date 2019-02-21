using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class SmsTest
    {
        [Fact]
        public async void SendSms()
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

                var messageInfo = await rc.Restapi().Account().Extension().Sms().Post(new CreateSMSMessage
                {
                    from = new MessageStoreCallerInfoRequest
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                    },
                    to = new[]
                    {
                        new MessageStoreCallerInfoRequest
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
                        }
                    },
                    text = "Hello world"
                });
                Assert.Equal("SMS", messageInfo.type);
                Assert.Equal("Outbound", messageInfo.direction);
                Assert.Equal("Unread", messageInfo.readStatus);
            }
        }

        [Fact]
        public async void SendSmsComplicated()
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
                var httpContent = new StringContent(JsonConvert.SerializeObject(new
                {
                    from = new
                    {
                        phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME")
                    },
                    to = new[]
                    {
                        new
                        {
                            phoneNumber = Environment.GetEnvironmentVariable("RINGCENTRAL_RECEIVER")
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
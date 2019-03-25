using System;
using System.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class UserAgentTest
    {
        [Fact]
        public async void AfterCall()
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


                void EventHandler(object sender, HttpCallEventArgs eventArgs)
                {
                    var re = new RestException(eventArgs.httpResponseMessage, eventArgs.httpRequestMessage);
                    var str = re.ToString();
                    var userAgent = eventArgs.httpRequestMessage.Headers
                        .First(i => i.Key == "User-Agent").Value.ToArray();
                    Assert.Equal(new []{ "MyTestApp/0.0.1", "RingCentral.Net/1.0.0"}, userAgent);
                }

                rc.AfterHttpCall += EventHandler;

                var china = await rc.Restapi().Dictionary().Country("46").Get();
                Assert.Equal("China", china.name);

                rc.AfterHttpCall -= EventHandler;
            }
        }
    }
}
using System;
using System.Linq;
using RingCentral.Net.Events;
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

                var eventsExtension = new EventsExtension();
                await rc.InstallExtension(eventsExtension);

                var count = 0;

                void EventHandler(object sender, HttpMessages httpMessages)
                {
                    var userAgent = httpMessages.httpRequestMessage.Headers
                        .First(i => i.Key == "X-User-Agent").Value.ToArray();
                    Assert.Single(userAgent);
                    Assert.StartsWith("Unknown/0.0.1 RingCentral.Net/", userAgent[0]);
                    count += 1;
                }

                eventsExtension.RequestSuccess += EventHandler;

                var china = await rc.Restapi().Dictionary().Country("46").Get();
                Assert.Equal("China", china.name);
                Assert.Equal(1, count);

                eventsExtension.RequestSuccess -= EventHandler;
            }
        }
    }
}
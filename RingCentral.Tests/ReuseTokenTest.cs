using System;
using RingCentral.Net.PubNub;
using Xunit;

namespace RingCentral.Tests
{
    public class ReuseTokenTest
    {
        [Fact]
        public async void ReuseTokenAfterSubscription()
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
                var pubNubExtension = new PubNubExtension();
                await rc.InstallExtension(pubNubExtension);

                var cachedToken = rc.token;

                // use the token to make API call
                rc.token = cachedToken;
                var ext = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(ext.id);

                // create a subscription
                var subscription = await pubNubExtension.Subscribe(
                    new[] {"/restapi/v1.0/account/~/extension/~/message-store"},
                    message => { Console.WriteLine(message); });

                // use the token again to make API call
                rc.token = cachedToken;
                ext = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(ext.id);
            }
        }
    }
}
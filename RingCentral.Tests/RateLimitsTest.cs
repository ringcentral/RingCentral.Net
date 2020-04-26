using System;
using Xunit;

namespace RingCentral.Tests
{
    public class RateLimitsTest
    {
        [Fact]
        public async void CheckRateLimit()
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

                Assert.Null(rc.rateLimits.medium.updatedAt);
                Assert.Null(rc.rateLimits.medium.remaining);

                await rc.Restapi().Account().Extension().Sms().Post(new CreateSMSMessage
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

                Assert.NotNull(rc.rateLimits.medium.updatedAt);
                Assert.NotNull(rc.rateLimits.medium.remaining);
                Assert.True(rc.rateLimits.medium.remaining > 0);
            }
        }
    }
}
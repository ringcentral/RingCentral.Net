using System;
using Xunit;

namespace RingCentral.Net.Tests
{
    public class GetTest
    {
        [Fact]
        public async void TestGetCountry()
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RingCentral(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSS_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                var r = await rc.Get<CountryInfo>("/restapi/v1.0/dictionary/country/1");
                Assert.Equal(200, r.metadata.status);
                Assert.Equal("United States", r.body.name);
            }
        }

        [Fact]
        public async void TestStringResponse()
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RingCentral(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSS_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                var r = await rc.Get<string>("/restapi/v1.0/dictionary/country/1");
                Assert.Equal(200, r.metadata.status);
                Assert.Null(r.body); // because object cannot be converted to string.
                Assert.Contains("United States", r.message);
            }
        }

        [Fact]
        public async void TestGetCallLog()
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RingCentral(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSS_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                var r = await rc.Get<CountryInfo>("/restapi/v1.0/account/~/extension/~/call-log");
                Assert.Equal(200, r.metadata.status);

                var r2 = await rc.Get<UserCallLogResponse>("/restapi/v1.0/account/~/extension/~/call-log?direction=Inbound&dateFrom=2018-01-13T06:57:00.000Z");
                Assert.Equal(200, r2.metadata.status);
                Assert.Equal("Inbound", r2.body.records[0].direction);
            }
        }
    }
}

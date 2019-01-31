using System;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class ScimTest
    {
        [Fact]
        public async Task GetServiceProviderConfig()
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

                var serviceProviderConfig = await rc.Scim().ServiceProviderConfig().Get();
                Assert.Equal(new[] {"urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig"},
                    serviceProviderConfig.schemas);
            }
        }

        [Fact]
        public async Task CheckHealth()
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

                var str = await rc.Scim().Health().Get();
                Assert.Equal("OK", str);

                var str2 = await rc.Scim(null).Health().Get();
                Assert.Equal("OK", str2);
            }
        }

        [Fact]
        public async Task GetUsers()
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

                var userSearchResponse = await rc.Scim().Users().Get();
                Assert.True(userSearchResponse.Resources.Length > 0);
                Assert.True(userSearchResponse.totalResults > 0);
                Assert.Equal(1, userSearchResponse.startIndex);
            }
        }

        [Fact]
        public async Task CreateUser()
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

                var user = new User
                {
                    emails = new[]
                    {
                        new Email
                        {
                            type = "work",
                            value = "tyler.liu@ringcentral.com"
                        }
                    },
                    name = new Name
                    {
                        familyName = "Liu",
                        givenName = "Tyler"
                    },
                    schemas = new[] {"urn:ietf:params:scim:schemas:core:2.0:User"},
                    userName = "tyler.liu@ringcentral.com"
                };
                var userResponse = await rc.Scim().Users().Post(user);
                Assert.Equal("Liu", userResponse.name.familyName);
                Assert.Equal("Tyler", userResponse.name.givenName);

                // don't forget to delete it after testing
                var str = await rc.Scim().Users(userResponse.id).Delete();
                Assert.Equal("", str);
            }
        }

        [Fact]
        public async Task SearchUser()
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

                var seachRequest = new SearchRequest
                {
                };
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(seachRequest);
                Assert.True(userSearchResponse.Resources.Length > 0);
                Assert.True(userSearchResponse.totalResults > 0);
                Assert.Equal(1, userSearchResponse.startIndex);
            }
        }
    }
}
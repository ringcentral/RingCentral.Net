using System;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class ScimTest
    {
        private const string EMAIL = "test.user@example.com";

        // Get Service Provider Config:  HTTP GET /scim/v2/ServiceProviderConfig
        [Fact]
        public async void GetServiceProviderConfig()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
                // to get the whole response as a string
                var str = await rc.Get<string>("/scim/v2/ServiceProviderConfig");
                Assert.Contains("urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig", str);

                // to get the response as a C# object
                var serviceProviderConfig = await rc.Scim().ServiceProviderConfig().Get();
                Assert.Equal(new[] {"urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig"},
                    serviceProviderConfig.schemas);
            }
        }

        // Check Health:  HTTP GET /scim/v2/health
        [Fact]
        public async void CheckHealth()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                // // "OK" means SCIM system has no problem
                // var str = await rc.Scim().Health().Get();
                // Assert.Equal("OK", str);
                //
                // // This is equivalent to above
                // var str2 = await rc.Scim(null).Health().Get();
                // Assert.Equal("OK", str2);
            }
        }

        // List all the SCIM users: HTTP GET /scim/v2/Users
        [Fact]
        public async void GetUsers()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                // list all SCIM users
                var userSearchResponse = await rc.Scim().Users().List();
                Assert.True(userSearchResponse.Resources.Length > 0);
                Assert.True(userSearchResponse.totalResults > 0);
                Assert.Equal(1, userSearchResponse.startIndex);
            }
        }

        // Create a SCIM user: HTTP POST /scim/v2/Users
        [Fact]
        public async void CreateUser()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                // delete existing user first, we don't want to create duplicate users
                var searchRequest = new ScimSearchRequest
                {
                    count = 1,
                    filter = $"emails eq \"{EMAIL}\""
                };
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(searchRequest);
                if (userSearchResponse.Resources.Length == 1)
                    await rc.Scim().Users(userSearchResponse.Resources[0].id).Delete();

                // create the user
                var user = new ScimUser
                {
                    emails = new[]
                    {
                        new ScimEmail
                        {
                            type = "work",
                            value = EMAIL
                        }
                    },
                    name = new ScimName
                    {
                        familyName = "LastName",
                        givenName = "FirstName"
                    },
                    schemas = new[] {"urn:ietf:params:scim:schemas:core:2.0:User"},
                    userName = EMAIL
                };
                var userResponse = await rc.Scim().Users().Post(user);
                Assert.Equal("LastName", userResponse.name.familyName);
                Assert.Equal("FirstName", userResponse.name.givenName);

                // don't forget to delete it after testing
                var str = await rc.Scim().Users(userResponse.id).Delete();
                Assert.Equal("", str);
            }
        }

        // Search SCIM user: HTTP POST /scim/v2/Users/.search
        [Fact]
        public async void SearchUser()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                // search user and return 10 results
                var searchRequest = new ScimSearchRequest
                {
                    count = 10
                };
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(searchRequest);
                Assert.True(userSearchResponse.Resources.Length > 0);
                Assert.True(userSearchResponse.totalResults > 0);
                Assert.Equal(1, userSearchResponse.startIndex);
            }
        }

        // Get SCIM user by ID: HTTP GET /scim/v2/Users/{id}
        [Fact]
        public async void GetUserById()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                // list 10 users and use the first one for testing
                var searchRequest = new ScimSearchRequest
                {
                    count = 10
                };
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(searchRequest);
                var firstUser = userSearchResponse.Resources[0];

                // get user by ID
                var user = await rc.Scim().Users(firstUser.id).Get();
                Assert.Equal(user.id, firstUser.id);
                Assert.Equal(user.name.familyName, firstUser.name.familyName);
                Assert.Equal(user.name.givenName, firstUser.name.givenName);
            }
        }

        // Update a SCIM user: HTTP PUT /scim/v2/Users/{id}
        [Fact]
        public async void UpdateUser()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                var searchRequest = new ScimSearchRequest
                {
                    count = 1,
                    filter = "emails eq \"test.user@example.com\""
                };
                // search for the user
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(searchRequest);
                if (userSearchResponse.Resources.Length == 1)
                {
                    var userResponse = userSearchResponse.Resources[0];

                    // create a new use object by JSON serialization and deserialization
                    var user = JsonConvert.DeserializeObject<ScimUser>(JsonConvert.SerializeObject(userResponse));
                    var guid = Guid.NewGuid().ToString();

                    // update family name of the new user
                    user.name.familyName = guid;
                    var ur = await rc.Scim().Users(user.id).Put(user);
                    Assert.Equal("test.user@example.com", ur.emails[0].value);
                    // make sure user has new family name
                    Assert.Equal(guid, ur.name.familyName);
                }
            }
        }

        // Patch a SCIM user: HTTP PATCH /scim/v2/Users/{id}
        // Patch is for update data fields by path
        [Fact]
        public async void PatchUser()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );

                var searchRequest = new ScimSearchRequest
                {
                    count = 1,
                    filter = "emails eq \"test.user@example.com\""
                };
                // search for the SCIM user
                var userSearchResponse = await rc.Scim().Users().DotSearch().Post(searchRequest);
                if (userSearchResponse.Resources.Length == 1)
                {
                    var userResponse = userSearchResponse.Resources[0];

                    var guid = Guid.NewGuid().ToString();
                    var userPatch = new ScimUserPatch
                    {
                        schemas = new[]
                        {
                            "urn:ietf:params:scim:api:messages:2.0:PatchOp"
                        },
                        Operations = new[]
                        {
                            new ScimPatchOperation
                            {
                                op = "replace",
                                path = "name.familyName",
                                value = guid
                            }
                        }
                    };
                    // patch it
                    var ur = await rc.Scim().Users(userResponse.id).Patch(userPatch);
                    Assert.Equal("test.user@example.com", ur.emails[0].value);

                    // make sure data patched successfully
                    Assert.Equal(guid, ur.name.familyName);
                }
            }
        }
    }
}
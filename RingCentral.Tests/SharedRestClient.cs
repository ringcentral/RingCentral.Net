using System;
using System.Threading.Tasks;

namespace RingCentral.Tests
{
    public static class SharedRestClient
    {
        private static RestClient _restClient;

        public static async Task<RestClient> GetInstance()
        {
            if (_restClient == default(RestClient))
            {
                _restClient = new RestClient(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                );
                await _restClient.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_JWT_TOKEN")
                );
            }
            else
            {
                // create a new rest client but reuse existing token
                var token = _restClient.token;
                _restClient = new RestClient(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                );
                _restClient.token = token;
            }

            return _restClient;
        }
    }
}
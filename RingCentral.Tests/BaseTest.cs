using System;
using System.Threading.Tasks;

namespace RingCentral.Tests
{
    public class BaseTest
    {
        public async void AutoAuth(Action<RestClient> action)
        {
            var env = Environment.GetEnvironmentVariables();
            using (var rc = new RestClient(
                env["RINGCENTRAL_CLIENT_ID"] as string,
                env["RINGCENTRAL_CLIENT_SECRET"] as string,
                env["RINGCENTRAL_WSG_URL"] as string
            ))
            {
                await rc.Authorize(
                    env["RINGCENTRAL_USERNAME"] as string,
                    env["RINGCENTRAL_EXTENSION"] as string,
                    env["RINGCENTRAL_PASSWORD"] as string
                );
                action(rc);
            }
        }
    }
}

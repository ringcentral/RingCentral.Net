using System;
using RingCentral.Net.WebSocket;
using Xunit;
using dotenv.net;

namespace RingCentral.Tests
{
    public class WebSocketTest
    {
        [Fact]
        public async void SendAndReceive()
        {
            DotEnv.Config(false);
            if (Environment.GetEnvironmentVariable("IS_PROD_ENV") != "true")
            {
                return;
            }
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
                var webSocketExtension = new WebSocketExtension();
                rc.InstallExtension(webSocketExtension);
                Console.ReadLine();
            }
        }
    }
}
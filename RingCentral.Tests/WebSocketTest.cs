using System;
using System.Threading.Tasks;
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
            if (Environment.GetEnvironmentVariable("IS_LAB_ENV") != "true")
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
                await rc.InstallExtension(webSocketExtension);
                var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
                await webSocketExtension.Subscribe(eventFilters, message =>
                {
                    Assert.NotNull(message);
                });
                await Task.Delay(999999999);
            }
        }
    }
}
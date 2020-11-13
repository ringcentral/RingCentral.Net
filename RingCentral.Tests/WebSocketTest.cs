using System;
using System.Threading.Tasks;
using RingCentral.Net.WebSocket;
using Xunit;
using dotenv.net;
using RingCentral.Net.AutoRefresh;
using Xunit.Abstractions;

namespace RingCentral.Tests
{
    public class WebSocketTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public WebSocketTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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
                var webSocketExtension = new WebSocketExtension(new WebSocketOptions{debugMode = true});
                Console.SetOut(new MyTextWriter(_testOutputHelper));
                await rc.InstallExtension(webSocketExtension);
                var autoRefreshExtension = new AutoRefreshExtension();
                await rc.InstallExtension(autoRefreshExtension);
                var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
                await webSocketExtension.Subscribe(eventFilters, message =>
                {
                    _testOutputHelper.WriteLine(message);
                });
                while (true)
                {
                    await rc.Restapi().Account().Extension().CompanyPager().Post(new CreateInternalTextMessageRequest
                    {
                        from = new PagerCallerInfoRequest {extensionNumber = "101"},
                        to = new[] {new PagerCallerInfoRequest {extensionNumber = "101"}},
                        text = "Hello world",
                    });
                    await Task.Delay(60000);
                }
            }
        }
    }
}
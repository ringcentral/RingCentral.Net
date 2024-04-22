using System.Threading.Tasks;
using RingCentral.Net.WebSocket;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class WebSocketTest
    {
        [Fact]
        public async void SendAndReceive()
        {
            var rc = await SharedRestClient.GetInstance();
            var webSocketExtension = new WebSocketExtension(new WebSocketOptions {debugMode = true});
            await rc.InstallExtension(webSocketExtension);
            var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
            var count = 0;
            await webSocketExtension.Subscribe(eventFilters, message => { count += 1; });
            var extInfo = await rc.Restapi().Account().Extension().Get();
            await rc.Restapi().Account().Extension().CompanyPager().Post(new CreateInternalTextMessageRequest
            {
                from = new PagerCallerInfoRequest {extensionNumber = extInfo.extensionNumber},
                to = new[] {new PagerCallerInfoRequest {extensionNumber = extInfo.extensionNumber}},
                text = "Hello world"
            });
            await Task.Delay(20000);
            Assert.True(count > 0);
            webSocketExtension.enabled = false;
        }

        [Fact]
        public async void RevokeSubscription()
        {
            var rc = await SharedRestClient.GetInstance();
            var webSocketExtension = new WebSocketExtension(new WebSocketOptions {debugMode = true});
            await rc.InstallExtension(webSocketExtension);
            var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
            var subscription = await webSocketExtension.Subscribe(eventFilters, message => { });
            webSocketExtension.RawMessageReceived += (sender, s) => { };
            await Task.Delay(5000);
            await subscription.Revoke();
            webSocketExtension.enabled = false;
        }
    }
}
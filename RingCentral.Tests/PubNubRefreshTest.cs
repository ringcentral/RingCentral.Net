using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    [Collection("Sequential")]
    public class PubNubRefreshTest
    {
        [Fact]
        public async void Renew()
        {
            var rc = await SharedRestClient.GetInstance();

            var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
            var requestBody = new
            {
                eventFilters,
                deliveryMode = new {transportType = "PubNub", encryption = true}
            };
            var httpContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8,
                "application/json");
            var subscriptionInfo1 = await rc.Post<SubscriptionInfo>("/restapi/v1.0/subscription", httpContent);
            var subscriptionInfo2 =
                await rc.Put<SubscriptionInfo>($"/restapi/v1.0/subscription/{subscriptionInfo1.id}", httpContent);
            // address doesn't change after put
            Assert.Equal(subscriptionInfo1.deliveryMode.address, subscriptionInfo2.deliveryMode.address);
            var str1 = JsonConvert.SerializeObject(subscriptionInfo1.deliveryMode);
            var str2 = JsonConvert.SerializeObject(subscriptionInfo2.deliveryMode);
            Assert.Equal(str1, str2); // deliveryMode doesn't change after renewal
        }
    }
}
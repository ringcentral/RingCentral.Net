using System.Linq;
using Xunit;

namespace RingCentral.Tests;

[Collection("Sequential")]
public class BatchApiTest
{
    [Fact]
    public async void MessageStoreBatchGet()
    {
        var rc = await ReusableRestClient.GetInstance();

        var messages = await rc.Restapi().Account().Extension().MessageStore().List(new ListMessagesParameters
        {
            perPage = 2, dateFrom = "2016-03-10T18:07:52.534Z",
        });

        if (messages.records.Length == 2)
        {
            var messageIds = string.Join(",", messages.records.Select(r => r.id.ToString()));
            var endpoint = rc.Restapi().Account().Extension().MessageStore(messageIds).Path();
            var restRequestConfig = RestRequestConfig.DefaultInstance;
            restRequestConfig.customHeaders.Add("Accept", "application/vnd.ringcentral.multipart+json");
            var result = await rc.Get<string>(endpoint, null, restRequestConfig);
            Assert.NotNull(result);
        }
    }
}
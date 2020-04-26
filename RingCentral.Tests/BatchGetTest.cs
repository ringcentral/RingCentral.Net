using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Xunit;

namespace RingCentral.Tests
{
    public class BatchGetTest
    {
        [Fact]
        public async void GetMessages()
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

                var messages = await rc.Restapi().Account().Extension().MessageStore().List();
                var ids = "7897036116," + string.Join(",", messages.records.Take(3).Select(m => m.id)) + ",7897036115";
                // var ids = string.Join(",", messages.records.Take(3).Select(m => m.id));

                void EventHandler(object sender, HttpCallEventArgs eventArgs)
                {
                    var message = Utils.FormatHttpMessage(eventArgs.httpResponseMessage, eventArgs.httpRequestMessage);
                }

                rc.AfterHttpCall += EventHandler;

                var r = await rc.Get<string>(rc.Restapi().Account().Extension().MessageStore(ids).Path());
                Assert.NotNull(r);

                var r2 = await rc.BatchGet<GetMessageInfoResponse>(rc.Restapi().Account().Extension().MessageStore(ids)
                    .Path());
                foreach (var batchResponse in r2)
                {
                    Console.WriteLine(batchResponse.summary.status);
                }
            }
        }
    }
}
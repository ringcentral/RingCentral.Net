using System;
using System.Linq;
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
                var validId1 = messages.records[0].id;
                var validId2 = messages.records[1].id;
                var invalidId = "7897036116";
                var batchResponses = await rc.BatchGet<GetMessageInfoResponse>(rc.Restapi().Account().Extension()
                    .MessageStore($"{validId1},{invalidId},{validId2}").Path());
                Assert.Equal(3, batchResponses.Length);

                var firstResponse = batchResponses[0];
                Assert.Equal(validId1, firstResponse.content.id);
                Assert.Equal(200, firstResponse.summary.status);
                Assert.Null(firstResponse.error);
                Assert.False(firstResponse.summary.isError);

                var secondResponse = batchResponses[1];
                Assert.True(secondResponse.summary.isError);
                Assert.Null(secondResponse.content);
                Assert.NotNull(secondResponse.error);
                Assert.Equal(404, secondResponse.summary.status);

                var thirdResponse = batchResponses[2];
                Assert.Equal(validId2, thirdResponse.content.id);
                Assert.Equal(200, thirdResponse.summary.status);
                Assert.Null(thirdResponse.error);
                Assert.False(thirdResponse.summary.isError);
            }
        }

        [Fact]
        public async void GetCallLogs()
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

                var callLogsResponse = await rc.Restapi().Account().Extension().CallLog()
                    .List(new ReadUserCallLogParameters {perPage = 3});
                var callLogIds = string.Join(',', callLogsResponse.records.Select(r => r.id));

                var batchResponses = await rc.Restapi().Account().Extension().CallLog(callLogIds).BatchGet();

                Assert.Equal(3, batchResponses.Length);
                var callLog = batchResponses[0].content;
                Assert.NotNull(callLog);
                Assert.NotNull(callLog.id);
                Assert.Equal(callLogIds, string.Join(',', batchResponses.Select(br => br.content.id)));
            }
        }

        [Fact]
        public async void GetCallLogs2()
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

                var callLogsResponse = await rc.Restapi().Account().Extension().CallLog()
                    .List(new ReadUserCallLogParameters {perPage = 3});
                var callLogIds = string.Join(',', callLogsResponse.records.Select(r => r.id));

                var batchResponses =
                    await rc.BatchGet<UserCallLogRecord>(rc.Restapi().Account().Extension().CallLog(callLogIds).Path());

                Assert.Equal(3, batchResponses.Length);
                Assert.Equal(callLogIds, string.Join(',', batchResponses.Select(br => br.content.id)));
            }
        }

        [Fact]
        public async void OnlyOneId()
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

                var callLogsResponse = await rc.Restapi().Account().Extension().CallLog()
                    .List(new ReadUserCallLogParameters {perPage = 1});
                var callLogIds = string.Join(',', callLogsResponse.records.Select(r => r.id));
                ArgumentException argumentException = null;
                try
                {
                    var batchResponses =
                        await rc.BatchGet<UserCallLogRecord>(rc.Restapi().Account().Extension().CallLog(callLogIds)
                            .Path());
                }
                catch (ArgumentException ae)
                {
                    argumentException = ae;
                }
                finally
                {
                    Assert.NotNull(argumentException);
                    Assert.Contains("should contain multiple IDs", argumentException.Message);
                }
            }
        }
    }
}
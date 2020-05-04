using System;
using System.IO;
using Xunit;

namespace RingCentral.Tests
{
    public class MessageArchiveTest
    {
        [Fact]
        public async void DownloadMessageReportArchive()
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

//                var messageStoreReport = await rc.Restapi().Account().MessageStoreReport().Post(
//                    new CreateMessageStoreReportRequest
//                    {
//                        dateFrom = DateTime.Now.AddDays(-30).ToString("o")
//                    });
//                var reportId = messageStoreReport.id;
//                var reportId = "130829004-130829004-460fbdfb75a744b9b5ca4551c8e23bad";
//                Console.WriteLine(reportId);
//                var report = await rc.Restapi().Account().MessageStoreReport(reportId).Get();
//                Console.WriteLine(report.status);
//                var archiveList = await rc.Restapi().Account().MessageStoreReport(reportId).Archive().List();
//                var count = 0;
//                foreach (var archive in archiveList.records)
//                {
//                    var bytes = await rc.Get<byte[]>(archive.uri);
//                    File.WriteAllBytes($"{count}.zip", bytes);
//                    count++;
//                }
            }
        }
    }
}
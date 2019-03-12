using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace RingCentral.Tests
{
    public class GlipExportTest
    {
        [Fact]
        public async void ExportGlipData()
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
//                // can only be done once per day
//                var r = await rc.Restapi().Glip().DataExport().Post(new CreateDataExportTaskRequest());
//                Assert.Equal("Accepted", r.status);
//                
//                await Task.Delay(60000);
//                var r2 = await rc.Restapi().Glip().DataExport(r.id).Get();
//                Assert.Equal("Completed", r2.status);
//
//                var content = await rc.Get<byte[]>(r2.result[0].uri);
//                Assert.True(content.Length > 0);
//                File.WriteAllBytes("test.zip", content);
            }
        }
        
        
//        // cannot do it because there is no api to list existing tasks
//        [Fact]
//        public async void DowloadArchieve()
//        {
//            using (var rc = new RestClient(
//                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
//                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
//                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
//            ))
//            {
//                await rc.Authorize(
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
//                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
//                );
//            }
//        }
    }
}
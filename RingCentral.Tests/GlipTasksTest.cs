using System;
using Xunit;

namespace RingCentral.Tests
{
    public class GlipTasksTest
    {
        [Fact]
        public async void AllTaskOperations()
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

                // Find the group with type "Personal" where you can talk to yourself
                var groups = await rc.Restapi().Glip().Chats().List(new ListGlipChatsParameters
                {
                    type = new[] {"Personal"}
                });
                var group = groups.records[0];

                // Create a task
                var task = await rc.Restapi().Glip().Chats(group.id).Tasks().Post(new GlipCreateTask
                {
                    subject = "This is a sample task"
                });

                // List all the tasks in the group
                var tasks = await rc.Restapi().Glip().Chats(group.id).Tasks().Get();
                Assert.True(tasks.records.Length > 0);

                //  patch the task
                await rc.Restapi().Glip().Tasks(task.id).Patch(new GlipUpdateTask
                {
                    subject = "This is the new task subject"
                });

                // complete the task
                await rc.Restapi().Glip().Tasks(task.id).Complete().Post(new GlipCompleteTask {status = "Complete"});

                // Get the task
                task = await rc.Restapi().Glip().Tasks(task.id).Get();

                // Check data
                Assert.Equal("This is the new task subject", task.subject);
                Assert.Equal("Completed", task.status);

                // delete the task
                await rc.Restapi().Glip().Tasks(task.id).Delete();
            }
        }
    }
}
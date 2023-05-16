using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Tasks.Complete
{
    public class Index
    {
        public Tasks.Index parent;
        public RestClient rc;

        public Index(Tasks.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/complete";
        }

        /// <summary>
        ///     Completes a task in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/tasks/{taskId}/complete
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(TMCompleteTaskRequest tMCompleteTaskRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), tMCompleteTaskRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Tasks
{
    public partial class Index
    {
        public Complete.Index Complete()
        {
            return new Complete.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Tasks.Complete
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Tasks.Index parent;
public Index(TeamMessaging.V1.Tasks.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/complete";
        }
        /// <summary>
        /// Completes a task in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/tasks/{taskId}/complete
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Post(RingCentral.TMCompleteTaskRequest tMCompleteTaskRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<string>(this.Path(), tMCompleteTaskRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Tasks
{
    public partial class Index
    {
        public TeamMessaging.V1.Tasks.Complete.Index Complete()
        {
            return new TeamMessaging.V1.Tasks.Complete.Index(this);
        }
    }
}
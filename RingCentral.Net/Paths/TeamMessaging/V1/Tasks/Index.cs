using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Tasks
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string taskId;
public Index(TeamMessaging.V1.Index parent, string taskId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.taskId = taskId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/tasks/{taskId}";
            }
            return $"{parent.Path()}/tasks";
        }
        /// <summary>
        /// Returns information about the specified task(s) by ID(s).
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTaskInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (taskId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
    }return await rc.Get<RingCentral.TMTaskInfo>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Deletes the specified task.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (taskId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }

        /// <summary>
        /// Updates the specified task by ID.
        /// HTTP Method: patch
        /// Endpoint: /team-messaging/v1/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMTaskList> Patch(RingCentral.TMUpdateTaskRequest tMUpdateTaskRequest, RestRequestConfig restRequestConfig = null)
  {
if (taskId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
    }return await rc.Patch<RingCentral.TMTaskList>(this.Path(), tMUpdateTaskRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Tasks.Index Tasks(string taskId = null)
        {
            return new TeamMessaging.V1.Tasks.Index(this, taskId);
        }
    }
}
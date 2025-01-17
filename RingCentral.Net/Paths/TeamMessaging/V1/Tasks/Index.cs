using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Tasks
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(V1.Index parent, string taskId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null) return $"{parent.Path()}/tasks/{taskId}";

            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        ///     Returns information about the specified task(s) by ID(s).
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/tasks/{taskId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTaskInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Get<TMTaskInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified task.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/v1/tasks/{taskId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified task by ID.
        ///     HTTP Method: patch
        ///     Endpoint: /team-messaging/v1/tasks/{taskId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTaskList> Patch(TMUpdateTaskRequest tMUpdateTaskRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Patch<TMTaskList>(Path(), tMUpdateTaskRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public Tasks.Index Tasks(string taskId = null)
        {
            return new Tasks.Index(this, taskId);
        }
    }
}
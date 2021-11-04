using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Tasks
{
    public partial class Index
    {
        public Glip.Index parent;
        public RestClient rc;
        public string taskId;

        public Index(Glip.Index parent, string taskId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<GlipTaskInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Get<GlipTaskInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified task.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified task by ID.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<GlipTaskList> Patch(GlipUpdateTask glipUpdateTask,
            RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null) throw new ArgumentException("Parameter cannot be null", nameof(taskId));

            return await rc.Patch<GlipTaskList>(Path(), glipUpdateTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Tasks.Index Tasks(string taskId = null)
        {
            return new Tasks.Index(this, taskId);
        }
    }
}
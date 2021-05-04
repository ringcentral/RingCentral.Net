using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string taskId;

        public Index(Restapi.Glip.Index parent, string taskId = null)
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
        /// Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.GlipTaskInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
            }

            return await rc.Get<RingCentral.GlipTaskInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified task.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the specified task by ID.
        /// HTTP Method: patch
        /// Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.GlipTaskList> Patch(RingCentral.GlipUpdateTask glipUpdateTask,
            RestRequestConfig restRequestConfig = null)
        {
            if (taskId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(taskId));
            }

            return await rc.Patch<RingCentral.GlipTaskList>(this.Path(), glipUpdateTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Tasks.Index Tasks(string taskId = null)
        {
            return new Restapi.Glip.Tasks.Index(this, taskId);
        }
    }
}
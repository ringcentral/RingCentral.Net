using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Restapi.Glip.Index parent;

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
        /// Operation: Get Task
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GlipTaskInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.GlipTaskInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Patch Task
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GlipTaskList> Patch(RingCentral.GlipUpdateTask glipUpdateTask,
            CancellationToken? cancellationToken = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Patch<RingCentral.GlipTaskList>(this.Path(), glipUpdateTask, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Task
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/tasks/{taskId}
        /// Rate Limit Group: Medium
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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
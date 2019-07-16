using System.Threading.Tasks;

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
        /// Http Get /restapi/v1.0/glip/tasks/{taskId}
        /// </summary>
        public async Task<RingCentral.TaskList> Get()
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.TaskList>(this.Path());
        }

        /// <summary>
        /// Operation: Patch Task
        /// Http Patch /restapi/v1.0/glip/tasks/{taskId}
        /// </summary>
        public async Task<RingCentral.TaskList> Patch(RingCentral.GlipUpdateTask glipUpdateTask)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Patch<RingCentral.TaskList>(this.Path(), glipUpdateTask);
        }

        /// <summary>
        /// Operation: Delete Task
        /// Http Delete /restapi/v1.0/glip/tasks/{taskId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Delete<string>(this.Path());
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
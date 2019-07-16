using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Tasks.Complete
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Tasks.Index parent;

        public Index(Restapi.Glip.Tasks.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/complete";
        }

        /// <summary>
        /// Operation: Complete Task
        /// Http Post /restapi/v1.0/glip/tasks/{taskId}/complete
        /// </summary>
        public async Task<RingCentral.TaskList> Post(RingCentral.GlipCompleteTask glipCompleteTask)
        {
            return await rc.Post<RingCentral.TaskList>(this.Path(), glipCompleteTask);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Tasks
{
    public partial class Index
    {
        public Restapi.Glip.Tasks.Complete.Index Complete()
        {
            return new Restapi.Glip.Tasks.Complete.Index(this);
        }
    }
}
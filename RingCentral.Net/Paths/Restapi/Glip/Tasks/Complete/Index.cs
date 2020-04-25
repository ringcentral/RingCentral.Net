using System.Threading.Tasks;
using System.Threading;

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
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/glip/tasks/{taskId}/complete
        /// </summary>
        public async Task<string> Post(RingCentral.GlipCompleteTask glipCompleteTask,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), glipCompleteTask, null, cancellationToken);
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
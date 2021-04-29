using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Completes a task in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}/complete
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Post(RingCentral.GlipCompleteTask glipCompleteTask,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), glipCompleteTask, null, restRequestConfig);
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
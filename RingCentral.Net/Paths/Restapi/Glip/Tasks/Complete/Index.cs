using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Tasks.Complete
{
    public class Index
    {
        public Tasks.Index parent;
        public RestClient rc;

        public Index(Tasks.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/complete";
        }

        /// <summary>
        ///     Completes a task in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/tasks/{taskId}/complete
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<string> Post(GlipCompleteTask glipCompleteTask,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), glipCompleteTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Tasks
{
    public partial class Index
    {
        public Complete.Index Complete()
        {
            return new Complete.Index(this);
        }
    }
}
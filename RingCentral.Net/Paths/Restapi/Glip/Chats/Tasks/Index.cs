using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Chats.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        /// Returns the list of tasks of the specified chat.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/tasks
        /// Rate Limit Group: Heavy
        /// </summary>
        public async Task<RingCentral.GlipTaskList> Get(RingCentral.ListChatTasksParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipTaskList>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a task in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/tasks
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.GlipTaskInfo> Post(RingCentral.GlipCreateTask glipCreateTask,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GlipTaskInfo>(this.Path(), glipCreateTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Tasks.Index Tasks()
        {
            return new Restapi.Glip.Chats.Tasks.Index(this);
        }
    }
}
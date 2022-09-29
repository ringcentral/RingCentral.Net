using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Tasks
{
    public class Index
    {
        public Chats.Index parent;
        public RestClient rc;

        public Index(Chats.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        ///     Returns the list of tasks of the specified chat.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/tasks
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<GlipTaskList> Get(ListChatTasksParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipTaskList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a task in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/chats/{chatId}/tasks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<GlipTaskInfo> Post(GlipCreateTask glipCreateTask, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GlipTaskInfo>(Path(), glipCreateTask, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Tasks.Index Tasks()
        {
            return new Tasks.Index(this);
        }
    }
}
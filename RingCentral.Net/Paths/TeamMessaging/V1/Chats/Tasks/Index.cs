using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Tasks
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/tasks";
        }

        /// <summary>
        ///     Returns the list of tasks of the specified chat.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/tasks
        ///     Rate Limit Group: Heavy
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTaskList> Get(ListChatTasksNewParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMTaskList>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a task in the specified chat.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/chats/{chatId}/tasks
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMTaskInfo> Post(TMCreateTaskRequest tMCreateTaskRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<TMTaskInfo>(Path(), tMCreateTaskRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public Tasks.Index Tasks()
        {
            return new Tasks.Index(this);
        }
    }
}
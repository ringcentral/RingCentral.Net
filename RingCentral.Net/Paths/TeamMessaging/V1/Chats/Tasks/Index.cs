using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Tasks
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Chats.Index parent;
        public Index(TeamMessaging.V1.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/tasks";
        }
        /// <summary>
        /// Returns the list of tasks of the specified chat.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/chats/{chatId}/tasks
        /// Rate Limit Group: Heavy
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMTaskList> Get(RingCentral.ListChatTasksNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.TMTaskList>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a task in the specified chat.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/chats/{chatId}/tasks
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.TMTaskInfo> Post(RingCentral.TMCreateTaskRequest tMCreateTaskRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.TMTaskInfo>(this.Path(), tMCreateTaskRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Tasks.Index Tasks()
        {
            return new TeamMessaging.V1.Chats.Tasks.Index(this);
        }
    }
}
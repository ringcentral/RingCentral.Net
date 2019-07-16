using System.Threading.Tasks;

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
        /// Operation: Get Chat Tasks
        /// Http Get /restapi/v1.0/glip/chats/{chatId}/tasks
        /// </summary>
        public async Task<RingCentral.TaskList> Get(ListChatTasksParameters queryParams = null)
        {
            return await rc.Get<RingCentral.TaskList>(this.Path(), queryParams);
        }

        /// <summary>
        /// Operation: Create Task
        /// Http Post /restapi/v1.0/glip/chats/{chatId}/tasks
        /// </summary>
        public async Task<RingCentral.TaskList> Post(RingCentral.GlipCreateTask glipCreateTask)
        {
            return await rc.Post<RingCentral.TaskList>(this.Path(), glipCreateTask);
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
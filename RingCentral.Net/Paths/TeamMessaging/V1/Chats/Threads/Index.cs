using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Chats.Threads
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Chats.Index parent;
        public string threadId;
        public Index(TeamMessaging.V1.Chats.Index parent, string threadId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.threadId = threadId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && threadId != null)
            {
                return $"{parent.Path()}/threads/{threadId}";
            }
            return $"{parent.Path()}/threads";
        }

    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Chats
{
    public partial class Index
    {
        public TeamMessaging.V1.Chats.Threads.Index Threads(string threadId = null)
        {
            return new TeamMessaging.V1.Chats.Threads.Index(this, threadId);
        }
    }
}
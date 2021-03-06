using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Members
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallQueues.Index parent;

        public Index(Restapi.Account.CallQueues.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        /// Returns call queue group members.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/members
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallQueueMembers> Get(
            RingCentral.ListCallQueueMembersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueueMembers>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Members.Index Members()
        {
            return new Restapi.Account.CallQueues.Members.Index(this);
        }
    }
}
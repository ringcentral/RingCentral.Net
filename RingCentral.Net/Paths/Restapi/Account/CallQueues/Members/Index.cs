using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Members
{
    public class Index
    {
        public CallQueues.Index parent;
        public RestClient rc;

        public Index(CallQueues.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        ///     Returns a list of call queue group members.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/members
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<CallQueueMembers> Get(ListCallQueueMembersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallQueueMembers>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Members.Index Members()
        {
            return new Members.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups.Members
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallMonitoringGroups.Index parent;

        public Index(Restapi.Account.CallMonitoringGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        /// Returns call monitoring group members.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/members
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroupMemberList> Get(
            RingCentral.ListCallMonitoringGroupMembersParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroupMemberList>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public Restapi.Account.CallMonitoringGroups.Members.Index Members()
        {
            return new Restapi.Account.CallMonitoringGroups.Members.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Call Monitoring Group Member List
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members
        /// </summary>
        public async Task<RingCentral.CallMonitoringGroupMemberList> Get(
            ListCallMonitoringGroupMembersParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.CallMonitoringGroupMemberList>(this.Path(), queryParams, cancellationToken);
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
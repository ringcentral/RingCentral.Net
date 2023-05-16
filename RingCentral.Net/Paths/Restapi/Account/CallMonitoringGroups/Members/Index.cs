using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups.Members
{
    public class Index
    {
        public CallMonitoringGroups.Index parent;
        public RestClient rc;

        public Index(CallMonitoringGroups.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/members";
        }

        /// <summary>
        ///     Returns a list of members for a call monitoring group specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/members
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<CallMonitoringGroupMemberList> Get(
            ListCallMonitoringGroupMembersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallMonitoringGroupMemberList>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public Members.Index Members()
        {
            return new Members.Index(this);
        }
    }
}
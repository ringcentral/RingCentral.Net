using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        ///     Updates a list of call monitoring groups.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: Groups
        /// </summary>
        public async Task<string> Post(CallMonitoringBulkAssign callMonitoringBulkAssign,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), callMonitoringBulkAssign, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public BulkAssign.Index BulkAssign()
        {
            return new BulkAssign.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups.BulkAssign
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
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Updates call monitoring groups.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: Groups
        /// </summary>
        public async Task<string> Post(RingCentral.CallMonitoringBulkAssign callMonitoringBulkAssign,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), callMonitoringBulkAssign, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public Restapi.Account.CallMonitoringGroups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.CallMonitoringGroups.BulkAssign.Index(this);
        }
    }
}
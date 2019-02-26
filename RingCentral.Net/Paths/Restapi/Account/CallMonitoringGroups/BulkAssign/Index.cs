using System.Threading.Tasks;

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

        // Operation: updateCallMonitoringGroups
        public async Task<RingCentral.CallMonitoringBulkAssign> Post(
            RingCentral.CallMonitoringBulkAssign callMonitoringBulkAssign)
        {
            return await rc.Post<RingCentral.CallMonitoringBulkAssign>(this.Path(), callMonitoringBulkAssign);
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
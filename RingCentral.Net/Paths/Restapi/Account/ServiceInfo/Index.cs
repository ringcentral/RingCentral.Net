using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ServiceInfo
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/service-info";
        }

        // Operation: Get Account Service Info
        // Http Get /restapi/v1.0/account/{accountId}/service-info
        public async Task<RingCentral.GetServiceInfoResponse> Get()
        {
            return await rc.Get<RingCentral.GetServiceInfoResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ServiceInfo.Index ServiceInfo()
        {
            return new Restapi.Account.ServiceInfo.Index(this);
        }
    }
}
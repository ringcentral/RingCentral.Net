using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ActiveCalls
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
            return $"{parent.Path()}/active-calls";
        }

        /// <summary>
        /// Operation: Get Company Active Calls
        /// Http Get /restapi/v1.0/account/{accountId}/active-calls
        /// </summary>
        public async Task<RingCentral.ActiveCallsResponse> Get(ListCompanyActiveCallsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ActiveCalls.Index ActiveCalls()
        {
            return new Restapi.Account.ActiveCalls.Index(this);
        }
    }
}
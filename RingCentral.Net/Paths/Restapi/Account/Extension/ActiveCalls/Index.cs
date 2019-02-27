using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ActiveCalls
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/active-calls";
        }

        // Operation: listExtensionActiveCalls
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls
        public async Task<RingCentral.ActiveCallsResponse> Get(ListExtensionActiveCallsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.ActiveCalls.Index ActiveCalls()
        {
            return new Restapi.Account.Extension.ActiveCalls.Index(this);
        }
    }
}
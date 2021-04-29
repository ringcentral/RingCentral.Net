using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Returns records of all calls that are in progress, ordered by start time in descending order.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/active-calls
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.CompanyActiveCallsResponse> Get(
            RingCentral.ListCompanyActiveCallsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyActiveCallsResponse>(this.Path(), queryParams, restRequestConfig);
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
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /// <summary>
        /// Returns records of all extension calls that are in progress, ordered by start time in descending order.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/active-calls
        /// Rate Limit Group: Heavy
        /// App Permission: ReadCallLog
        /// User Permission: ReadCallLog
        /// </summary>
        public async Task<RingCentral.UserActiveCallsResponse> Get(
            RingCentral.ListExtensionActiveCallsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserActiveCallsResponse>(this.Path(), queryParams, restRequestConfig);
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
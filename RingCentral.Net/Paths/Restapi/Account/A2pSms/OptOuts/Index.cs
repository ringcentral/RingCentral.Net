using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.A2pSms.OptOuts
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.A2pSms.Index parent;

        public Index(Restapi.Account.A2pSms.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/opt-outs";
        }

        /// <summary>
        /// Returns the list of numbers opted out from the account. The list can be filtered by `to`/`from` phone number query parameters. Specifying `text/csv` in the Accept header downloads the data in CSV format.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/opt-outs
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// </summary>
        public async Task<RingCentral.OptOutListResponse> Get(
            RingCentral.ReadA2PSMSOptOutsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.OptOutListResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public Restapi.Account.A2pSms.OptOuts.Index OptOuts()
        {
            return new Restapi.Account.A2pSms.OptOuts.Index(this);
        }
    }
}
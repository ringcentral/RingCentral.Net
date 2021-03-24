using System.Threading.Tasks;

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
        /// Operation: Get Opted Out Numbers
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/a2p-sms/opt-outs
        /// Rate Limit Group: Light
        /// App Permission: A2PSMS
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.OptOutListResponse> Get(ReadA2PSMSOptOutsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
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
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.A2pSms.OptOuts
{
    public partial class Index
    {
        public A2pSms.Index parent;
        public RestClient rc;

        public Index(A2pSms.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/opt-outs";
        }

        /// <summary>
        ///     Returns the list of numbers opted out from the account. The list can be filtered by `to`/`from` phone number query
        ///     parameters. Specifying `text/csv` in the Accept header downloads the data in CSV format.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/a2p-sms/opt-outs
        ///     Rate Limit Group: Light
        ///     App Permission: A2PSMS
        /// </summary>
        public async Task<OptOutListResponse> Get(ReadA2PSMSOptOutsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<OptOutListResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.A2pSms
{
    public partial class Index
    {
        public OptOuts.Index OptOuts()
        {
            return new OptOuts.Index(this);
        }
    }
}
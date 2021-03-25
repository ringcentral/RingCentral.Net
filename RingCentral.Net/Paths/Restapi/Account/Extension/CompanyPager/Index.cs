using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CompanyPager
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
            return $"{parent.Path()}/company-pager";
        }

        /// <summary>
        /// Creates and sends an internal text message.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager
        /// Rate Limit Group: Medium
        /// App Permission: InternalMessages
        /// User Permission: InternalSMS
        /// </summary>
        public async Task<RingCentral.GetInternalTextMessageInfoResponse> Post(
            RingCentral.CreateInternalTextMessageRequest createInternalTextMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GetInternalTextMessageInfoResponse>(this.Path(),
                createInternalTextMessageRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CompanyPager.Index CompanyPager()
        {
            return new Restapi.Account.Extension.CompanyPager.Index(this);
        }
    }
}
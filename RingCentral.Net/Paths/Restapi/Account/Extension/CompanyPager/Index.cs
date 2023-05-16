using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CompanyPager
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/company-pager";
        }

        /// <summary>
        ///     Creates and sends an internal text message (company pager message).
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/company-pager
        ///     Rate Limit Group: Medium
        ///     App Permission: InternalMessages
        ///     User Permission: InternalSMS
        /// </summary>
        public async Task<GetInternalTextMessageInfoResponse> Post(
            CreateInternalTextMessageRequest createInternalTextMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GetInternalTextMessageInfoResponse>(Path(), createInternalTextMessageRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public CompanyPager.Index CompanyPager()
        {
            return new CompanyPager.Index(this);
        }
    }
}
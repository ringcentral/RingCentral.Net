using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Create Internal Text Message
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Post(
            RingCentral.CreateInternalTextMessageRequest createInternalTextMessageRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), createInternalTextMessageRequest,
                null, cancellationToken);
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
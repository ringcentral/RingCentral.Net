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

        // Operation: createInternalTextMessage
        public async Task<RingCentral.GetMessageInfoResponse> Post(
            RingCentral.CreateInternalTextMessageRequest createInternalTextMessageRequest)
        {
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), createInternalTextMessageRequest);
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
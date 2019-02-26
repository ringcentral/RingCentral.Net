using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Fax
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
            return $"{parent.Path()}/fax";
        }

        // Operation: sendFaxMessage
        public async Task<RingCentral.FaxResponse> Post(SendFaxMessageRequest sendFaxMessageRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(sendFaxMessageRequest);
            return await rc.Post<RingCentral.FaxResponse>(this.Path(), multipartFormDataContent);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Fax.Index Fax()
        {
            return new Restapi.Account.Extension.Fax.Index(this);
        }
    }
}
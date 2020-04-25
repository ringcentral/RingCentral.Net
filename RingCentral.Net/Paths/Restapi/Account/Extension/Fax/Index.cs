using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Create Fax Message
        /// Rate Limit Group: Heavy
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/fax
        /// </summary>
        public async Task<RingCentral.FaxResponse> Post(CreateFaxMessageRequest createFaxMessageRequest,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createFaxMessageRequest);
            return await rc.Post<RingCentral.FaxResponse>(this.Path(), multipartFormDataContent, null,
                cancellationToken);
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
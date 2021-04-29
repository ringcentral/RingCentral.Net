using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Creates and sends/resends a fax message. Resend can be implemented if sending has failed. Fax attachment size (both single and total) is limited to 50Mb.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/fax
        /// Rate Limit Group: Heavy
        /// App Permission: Faxes
        /// User Permission: OutboundFaxes
        /// </summary>
        public async Task<RingCentral.FaxResponse> Post(RingCentral.CreateFaxMessageRequest createFaxMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createFaxMessageRequest);
            return await rc.Post<RingCentral.FaxResponse>(this.Path(), multipartFormDataContent, null,
                restRequestConfig);
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
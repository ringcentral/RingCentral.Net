using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Fax
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
            return $"{parent.Path()}/fax";
        }

        /// <summary>
        ///     Creates and sends/re-sends a fax message. Re-send can be implemented
        ///     if sending has failed. Fax attachment size (both single and total) is
        ///     limited to 50Mb.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/fax
        ///     Rate Limit Group: Heavy
        ///     App Permission: Faxes
        ///     User Permission: OutboundFaxes
        /// </summary>
        public async Task<FaxResponse> Post(CreateFaxMessageRequest createFaxMessageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createFaxMessageRequest);
            return await rc.Post<FaxResponse>(Path(), multipartFormDataContent, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Fax.Index Fax()
        {
            return new Fax.Index(this);
        }
    }
}
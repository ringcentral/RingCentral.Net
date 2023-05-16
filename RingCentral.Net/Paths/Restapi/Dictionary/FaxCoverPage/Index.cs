using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.FaxCoverPage
{
    public class Index
    {
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/fax-cover-page";
        }

        /// <summary>
        ///     Returns fax cover pages available for the current extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/fax-cover-page
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<ListFaxCoverPagesResponse> Get(ListFaxCoverPagesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ListFaxCoverPagesResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public FaxCoverPage.Index FaxCoverPage()
        {
            return new FaxCoverPage.Index(this);
        }
    }
}
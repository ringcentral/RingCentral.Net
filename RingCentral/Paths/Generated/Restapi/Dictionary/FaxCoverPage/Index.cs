using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.FaxCoverPage
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/fax-cover-page";
        }

        public async Task<RingCentral.ListFaxCoverPagesResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.ListFaxCoverPagesResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.ListFaxCoverPagesResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.ListFaxCoverPagesResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Indicates the page number to retrieve. Only positive number values are accepted
        public long? page;

        // Indicates the page size (number of items)
        public long? perPage;
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.FaxCoverPage.Index FaxCoverPage()
        {
            return new Restapi.Dictionary.FaxCoverPage.Index(this);
        }
    }
}
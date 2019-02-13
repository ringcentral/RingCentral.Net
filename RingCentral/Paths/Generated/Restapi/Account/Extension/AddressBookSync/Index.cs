using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AddressBookSync
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
            return $"{parent.Path()}/address-book-sync";
        }

        public class GetQueryParams
        {
            // Type of synchronization
            public string syncType;

            // Value of syncToken property of the last sync request response
            public string syncToken;

            // Number of records per page to be returned. The max number of records is 250, which is also the default. For 'FSync' if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For 'ISync' if the number of records exceeds the page size, the number of incoming changes to this number is limited
            public string perPage;

            // Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body
            public string pageId;
        }

        public async Task<RingCentral.AddressBookSync> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.AddressBookSync>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AddressBookSync.Index AddressBookSync()
        {
            return new Restapi.Account.Extension.AddressBookSync.Index(this);
        }
    }
}
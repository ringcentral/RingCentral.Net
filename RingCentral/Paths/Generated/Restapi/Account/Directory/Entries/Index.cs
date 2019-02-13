using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Directory.Index parent;

        public Index(Restapi.Account.Directory.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/entries";
        }

        public class GetQueryParams
        {
            // If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case
            public string showFederated;

            // Type of an extension
            // Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ParkLocation, Limited
            public string type;

            // Page number
            public string page;

            // Records count to be returned per one page. The default value is 1000. Specific keyword values: `all` - all records are returned in one page; `max` - maximum count of records that can be returned in one page
            public string perPage;

            // Internal identifier of the business site to which extensions belong
            public string siteId;
        }

        public async Task<RingCentral.DirectoryResource> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.DirectoryResource>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Index Entries()
        {
            return new Restapi.Account.Directory.Entries.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Entries.Search
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Directory.Entries.Index parent;

        public Index(Restapi.Account.Directory.Entries.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/search";
        }

        // Operation: searchDirectoryEntries
        public async Task<RingCentral.DirectoryResource> Post(
            RingCentral.SearchDirectoryEntriesRequest searchDirectoryEntriesRequest)
        {
            return await rc.Post<RingCentral.DirectoryResource>(this.Path(), searchDirectoryEntriesRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory.Entries
{
    public partial class Index
    {
        public Restapi.Account.Directory.Entries.Search.Index Search()
        {
            return new Restapi.Account.Directory.Entries.Search.Index(this);
        }
    }
}
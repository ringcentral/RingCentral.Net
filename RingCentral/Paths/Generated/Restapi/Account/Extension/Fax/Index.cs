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

        public async Task<RingCentral.FaxResponse> Post()
        {
            return await rc.Post<RingCentral.FaxResponse>(this.Path());
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
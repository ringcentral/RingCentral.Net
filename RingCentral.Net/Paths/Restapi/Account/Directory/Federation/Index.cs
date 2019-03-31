using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Directory.Federation
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
            return $"{parent.Path()}/federation";
        }

        /// <summary>
        /// Operation: Get Account Federation
        /// Http Get /restapi/v1.0/account/{accountId}/directory/federation
        /// </summary>
        public async Task<RingCentral.FederationResource> Get()
        {
            return await rc.Get<RingCentral.FederationResource>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Restapi.Account.Directory.Federation.Index Federation()
        {
            return new Restapi.Account.Directory.Federation.Index(this);
        }
    }
}
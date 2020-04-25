using System.Threading.Tasks;
using System.Threading;

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
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/account/{accountId}/directory/federation
        /// </summary>
        public async Task<RingCentral.FederationResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.FederationResource>(this.Path(), null, cancellationToken);
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
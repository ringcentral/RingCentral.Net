using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Status
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/status";
        }

        /// <summary>
        /// Operation: Get Service Status
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/status
        /// Rate Limit Group: NoThrottling
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.Status.Index Status()
        {
            return new Restapi.Status.Index(this);
        }
    }
}
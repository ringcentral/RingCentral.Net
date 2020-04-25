using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.RingOut
{
    public partial class Index
    {
        public RestClient rc;
        public string ringoutId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string ringoutId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ringoutId = ringoutId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ringoutId != null)
            {
                return $"{parent.Path()}/ring-out/{ringoutId}";
            }

            return $"{parent.Path()}/ring-out";
        }

        /// <summary>
        /// Operation: Make RingOut Call
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out
        /// Rate Limit Group: Heavy
        /// App Permission Required: RingOut
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Post(RingCentral.MakeRingOutRequest makeRingOutRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GetRingOutStatusResponse>(this.Path(false), makeRingOutRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get RingOut Call Status
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Light
        /// App Permission Required: RingOut
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Get<RingCentral.GetRingOutStatusResponse>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Cancel RingOut Call
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: RingOut
        /// User Permission Required: undefined
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.RingOut.Index RingOut(string ringoutId = null)
        {
            return new Restapi.Account.Extension.RingOut.Index(this, ringoutId);
        }
    }
}
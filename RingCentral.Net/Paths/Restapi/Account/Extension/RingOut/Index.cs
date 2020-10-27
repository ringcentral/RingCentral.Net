using System.Threading.Tasks;

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
        /// App Permission: RingOut
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Post(RingCentral.MakeRingOutRequest makeRingOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GetRingOutStatusResponse>(this.Path(false), makeRingOutRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Get RingOut Call Status
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Light
        /// App Permission: RingOut
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Get<RingCentral.GetRingOutStatusResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Cancel RingOut Call
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Heavy
        /// App Permission: RingOut
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.RingOut
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string ringoutId;

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
        /// Makes a 2-leg RingOut call.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out
        /// Rate Limit Group: Heavy
        /// App Permission: RingOut
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Post(RingCentral.MakeRingOutRequest makeRingOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.GetRingOutStatusResponse>(this.Path(false), makeRingOutRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Returns the status of a 2-leg RingOut call.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Light
        /// App Permission: RingOut
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ringoutId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ringoutId));
            }

            return await rc.Get<RingCentral.GetRingOutStatusResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Cancels a 2-leg RingOut call.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// Rate Limit Group: Heavy
        /// App Permission: RingOut
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ringoutId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ringoutId));
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
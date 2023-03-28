using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.RingOut
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;
        public string ringoutId;

        public Index(Extension.Index parent, string ringoutId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.ringoutId = ringoutId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ringoutId != null) return $"{parent.Path()}/ring-out/{ringoutId}";
            return $"{parent.Path()}/ring-out";
        }

        /// <summary>
        ///     Makes a 2-legged RingOut call.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out
        ///     Rate Limit Group: Heavy
        ///     App Permission: RingOut
        /// </summary>
        public async Task<GetRingOutStatusResponse> Post(MakeRingOutRequest makeRingOutRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<GetRingOutStatusResponse>(Path(false), makeRingOutRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a status of a 2-legged RingOut call.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        ///     Rate Limit Group: Light
        ///     App Permission: RingOut
        /// </summary>
        public async Task<GetRingOutStatusResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ringoutId == null) throw new ArgumentException("Parameter cannot be null", nameof(ringoutId));
            return await rc.Get<GetRingOutStatusResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Cancels a 2-legged RingOut call.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: RingOut
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ringoutId == null) throw new ArgumentException("Parameter cannot be null", nameof(ringoutId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public RingOut.Index RingOut(string ringoutId = null)
        {
            return new RingOut.Index(this, ringoutId);
        }
    }
}
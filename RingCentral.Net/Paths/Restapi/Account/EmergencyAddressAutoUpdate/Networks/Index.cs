using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Networks
{
    public partial class Index
    {
        public RestClient rc;
        public string networkId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string networkId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.networkId = networkId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && networkId != null)
            {
                return $"{parent.Path()}/networks/{networkId}";
            }

            return $"{parent.Path()}/networks";
        }

        /// <summary>
        /// Operation: Get Network Map
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks
        /// </summary>
        public async Task<RingCentral.NetworksList> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.NetworksList>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Network
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Post(RingCentral.CreateNetworkRequest createNetworkRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.NetworkInfo>(this.Path(false), createNetworkRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get Network
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Get<RingCentral.NetworkInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Network
        /// Http Put /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// </summary>
        public async Task<string> Put(RingCentral.UpdateNetworkRequest updateNetworkRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Put<string>(this.Path(), updateNetworkRequest, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Network
        /// Http Delete /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Networks.Index Networks(string networkId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Networks.Index(this, networkId);
        }
    }
}
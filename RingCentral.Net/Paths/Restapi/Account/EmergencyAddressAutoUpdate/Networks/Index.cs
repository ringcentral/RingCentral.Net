using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Networks
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;
        public string networkId;
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
        /// Returns a corporate network map with emergency addresses assigned
        /// to the current account.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworksList> List(RingCentral.ListNetworksParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.NetworksList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new network in a corporate ethernet map for assignment
        /// of emergency addresses to network access points.
        /// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Post(RingCentral.CreateNetworkRequest createNetworkRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.NetworkInfo>(this.Path(false), createNetworkRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns the specified network with emergency addresses assigned
        /// to the current account.
        /// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(networkId));
            }
            return await rc.Get<RingCentral.NetworkInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a network in a corporate ethernet map for assignment of emergency
        /// addresses to network access points.
        /// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Put(RingCentral.UpdateNetworkRequest updateNetworkRequest, RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(networkId));
            }
            return await rc.Put<RingCentral.NetworkInfo>(this.Path(), updateNetworkRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes network(s) in a corporate ethernet map for Automatic Location
        /// Updates feature.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(networkId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
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
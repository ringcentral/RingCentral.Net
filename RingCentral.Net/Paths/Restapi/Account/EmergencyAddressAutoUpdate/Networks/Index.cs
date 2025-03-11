using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Networks
{
    public class Index
    {
        public string networkId;
        public EmergencyAddressAutoUpdate.Index parent;
        public RestClient rc;

        public Index(EmergencyAddressAutoUpdate.Index parent, string networkId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.networkId = networkId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && networkId != null) return $"{parent.Path()}/networks/{networkId}";
            return $"{parent.Path()}/networks";
        }

        /// <summary>
        ///     Returns a corporate network map with emergency addresses assigned
        ///     to the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<NetworksList> List(ListNetworksParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<NetworksList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new network in a corporate ethernet map for assignment
        ///     of emergency addresses to network access points.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<NetworkInfo> Post(CreateNetworkRequest createNetworkRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<NetworkInfo>(Path(false), createNetworkRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns the specified network with emergency addresses assigned
        ///     to the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<NetworkInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null) throw new ArgumentException("Parameter cannot be null", nameof(networkId));
            return await rc.Get<NetworkInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a network in a corporate ethernet map for assignment of emergency
        ///     addresses to network access points.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<NetworkInfo> Put(UpdateNetworkRequest updateNetworkRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null) throw new ArgumentException("Parameter cannot be null", nameof(networkId));
            return await rc.Put<NetworkInfo>(Path(), updateNetworkRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes network(s) in a corporate ethernet map for Automatic Location
        ///     Updates feature.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (networkId == null) throw new ArgumentException("Parameter cannot be null", nameof(networkId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Networks.Index Networks(string networkId = null)
        {
            return new Networks.Index(this, networkId);
        }
    }
}
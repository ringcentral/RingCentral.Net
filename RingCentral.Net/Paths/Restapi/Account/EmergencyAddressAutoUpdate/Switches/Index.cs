using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Switches
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;
        public string switchId;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string switchId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.switchId = switchId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && switchId != null)
            {
                return $"{parent.Path()}/switches/{switchId}";
            }

            return $"{parent.Path()}/switches";
        }

        /// <summary>
        /// Returns corporate map of configured network switches with the assigned emergency addresses for the logged-in account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchesList> List(RingCentral.ListAccountSwitchesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.SwitchesList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new switch in corporate map based on chassis ID and used for Automatic Locations Update feature.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Post(RingCentral.CreateSwitchInfo createSwitchInfo,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SwitchInfo>(this.Path(false), createSwitchInfo, null, restRequestConfig);
        }

        /// <summary>
        /// Returns the specified switch with the assigned emergency address.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (switchId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(switchId));
            }

            return await rc.Get<RingCentral.SwitchInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates switch. Partial update is not supported, all switch parameters should be specified. If null value is received or parameter is missing, its value is removed.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Put(RingCentral.UpdateSwitchInfo updateSwitchInfo,
            RestRequestConfig restRequestConfig = null)
        {
            if (switchId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(switchId));
            }

            return await rc.Put<RingCentral.SwitchInfo>(this.Path(), updateSwitchInfo, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes wireless switch(es) in network configuration for Automatic Location Updates feature.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (switchId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(switchId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Switches.Index Switches(string switchId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Switches.Index(this, switchId);
        }
    }
}
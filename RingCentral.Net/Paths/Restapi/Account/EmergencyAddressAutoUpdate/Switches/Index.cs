using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Switches
{
    public partial class Index
    {
        public RestClient rc;
        public string switchId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

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
        /// Operation: Get Account Switch List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchesList> List(ListAccountSwitchesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.SwitchesList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Switch
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Post(RingCentral.CreateSwitchInfo createSwitchInfo,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.SwitchInfo>(this.Path(false), createSwitchInfo, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Switch
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Medium
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Get<RingCentral.SwitchInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Switch
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Put(RingCentral.UpdateSwitchInfo updateSwitchInfo,
            CancellationToken? cancellationToken = null)
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Put<RingCentral.SwitchInfo>(this.Path(), updateSwitchInfo, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Switch
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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
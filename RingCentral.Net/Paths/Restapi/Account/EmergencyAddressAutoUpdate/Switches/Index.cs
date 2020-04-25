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
        /// Rate Limit Group: Heavy
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// </summary>
        public async Task<RingCentral.SwitchesList> List(ListAccountSwitchesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.SwitchesList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Switch
        /// Rate Limit Group: Heavy
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Post(RingCentral.CreateSwitchInfo createSwitchInfo,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.SwitchInfo>(this.Path(false), createSwitchInfo, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Switch
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
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
        /// Rate Limit Group: Heavy
        /// Http Put /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
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
        /// Rate Limit Group: Heavy
        /// Http Delete /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
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
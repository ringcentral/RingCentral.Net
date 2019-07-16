using System.Threading.Tasks;

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
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// </summary>
        public async Task<RingCentral.SwitchesList> List(ListAccountSwitchesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.SwitchesList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Create Switch
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Post(RingCentral.CreateSwitchInfo createSwitchInfo)
        {
            return await rc.Post<RingCentral.SwitchInfo>(this.Path(false), createSwitchInfo);
        }

        /// <summary>
        /// Operation: Get Switch
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Get()
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Get<RingCentral.SwitchInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Switch
        /// Http Put /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// </summary>
        public async Task<RingCentral.SwitchInfo> Put(RingCentral.UpdateSwitchInfo updateSwitchInfo)
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Put<RingCentral.SwitchInfo>(this.Path(), updateSwitchInfo);
        }

        /// <summary>
        /// Operation: Delete Switch
        /// Http Delete /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.switchId == null)
            {
                throw new System.ArgumentNullException("switchId");
            }

            return await rc.Delete<string>(this.Path());
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
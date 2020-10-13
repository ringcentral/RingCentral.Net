using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkUpdate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/switches-bulk-update";
        }

        /// <summary>
        /// Operation: Update Multiple Switches
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.UpdateMultipleSwitchesResponse> Post(
            RingCentral.UpdateMultipleSwitchesRequest updateMultipleSwitchesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.UpdateMultipleSwitchesResponse>(this.Path(), updateMultipleSwitchesRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkUpdate.Index SwitchesBulkUpdate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkUpdate.Index(this);
        }
    }
}
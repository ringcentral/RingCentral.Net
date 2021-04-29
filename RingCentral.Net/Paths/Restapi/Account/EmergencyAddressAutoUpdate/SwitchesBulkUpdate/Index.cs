using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Updates multiple switches in corporate map. The maximum number of switches per request is 10 000; limitation for account is 10 000.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-update
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
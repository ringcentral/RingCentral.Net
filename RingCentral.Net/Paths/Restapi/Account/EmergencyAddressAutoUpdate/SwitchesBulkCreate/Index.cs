using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkCreate
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
            return $"{parent.Path()}/switches-bulk-create";
        }

        /// <summary>
        /// Operation: Create Multiple Switches
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.CreateMultipleSwitchesResponse> Post(
            RingCentral.CreateMultipleSwitchesRequest createMultipleSwitchesRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.CreateMultipleSwitchesResponse>(this.Path(), createMultipleSwitchesRequest,
                null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkCreate.Index SwitchesBulkCreate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkCreate.Index(this);
        }
    }
}
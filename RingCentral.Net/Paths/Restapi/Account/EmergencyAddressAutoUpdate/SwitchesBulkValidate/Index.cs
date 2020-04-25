using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkValidate
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
            return $"{parent.Path()}/switches-bulk-validate";
        }

        /// <summary>
        /// Operation: Validate Multiple Switches
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditAccounts
        /// User Permission Required: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.ValidateMultipleSwitchesResponse> Post(
            RingCentral.ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.ValidateMultipleSwitchesResponse>(this.Path(),
                validateMultipleSwitchesRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkValidate.Index SwitchesBulkValidate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkValidate.Index(this);
        }
    }
}
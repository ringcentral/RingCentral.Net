using System.Threading.Tasks;

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
        /// Validates switches before creation or update. The maximum number of switches per request is 10 000.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.ValidateMultipleSwitchesResponse> Post(
            RingCentral.ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ValidateMultipleSwitchesResponse>(this.Path(),
                validateMultipleSwitchesRequest, null, restRequestConfig);
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
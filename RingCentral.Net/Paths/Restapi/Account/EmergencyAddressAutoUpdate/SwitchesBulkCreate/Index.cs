using System.Threading.Tasks;

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
        /// Creates multiple switches in corporate map. The maximum number of switches per request is 10 000; limitation for account is 10 000.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.CreateMultipleSwitchesResponse> Post(
            RingCentral.CreateMultipleSwitchesRequest createMultipleSwitchesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CreateMultipleSwitchesResponse>(this.Path(), createMultipleSwitchesRequest,
                null, restRequestConfig);
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
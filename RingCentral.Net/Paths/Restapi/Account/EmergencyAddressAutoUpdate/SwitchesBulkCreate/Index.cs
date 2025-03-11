using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkCreate
{
    public class Index
    {
        public EmergencyAddressAutoUpdate.Index parent;
        public RestClient rc;

        public Index(EmergencyAddressAutoUpdate.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/switches-bulk-create";
        }

        /// <summary>
        ///     Creates multiple switches in corporate map. The maximum number
        ///     of switches per request is 10 000; limitation for account is 10 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-create
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<CreateMultipleSwitchesResponse> Post(
            CreateMultipleSwitchesRequest createMultipleSwitchesRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CreateMultipleSwitchesResponse>(Path(), createMultipleSwitchesRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public SwitchesBulkCreate.Index SwitchesBulkCreate()
        {
            return new SwitchesBulkCreate.Index(this);
        }
    }
}
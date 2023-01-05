using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkValidate
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

        public string Path()
        {
            return $"{parent.Path()}/switches-bulk-validate";
        }

        /// <summary>
        ///     Validates switches before creation or update. The maximum number
        ///     of switches per request is 10 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-validate
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<ValidateMultipleSwitchesResponse> Post(
            ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ValidateMultipleSwitchesResponse>(Path(), validateMultipleSwitchesRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public SwitchesBulkValidate.Index SwitchesBulkValidate()
        {
            return new SwitchesBulkValidate.Index(this);
        }
    }
}
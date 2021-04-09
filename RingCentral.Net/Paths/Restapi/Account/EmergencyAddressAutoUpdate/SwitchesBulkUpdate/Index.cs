using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.SwitchesBulkUpdate
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
            return $"{parent.Path()}/switches-bulk-update";
        }

        /// <summary>
        ///     Updates multiple switches in corporate map. The maximum number of switches per request is 10 000; limitation for
        ///     account is 10 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/switches-bulk-update
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<UpdateMultipleSwitchesResponse> Post(
            UpdateMultipleSwitchesRequest updateMultipleSwitchesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<UpdateMultipleSwitchesResponse>(Path(), updateMultipleSwitchesRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public SwitchesBulkUpdate.Index SwitchesBulkUpdate()
        {
            return new SwitchesBulkUpdate.Index(this);
        }
    }
}
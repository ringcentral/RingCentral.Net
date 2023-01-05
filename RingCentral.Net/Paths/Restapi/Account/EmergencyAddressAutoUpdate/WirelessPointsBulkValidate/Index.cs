using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkValidate
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
            return $"{parent.Path()}/wireless-points-bulk-validate";
        }

        /// <summary>
        ///     Validates wireless points before creation or update. The maximum
        ///     number of wireless points per request is 10 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<ValidateMultipleWirelessPointsResponse> Post(
            ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ValidateMultipleWirelessPointsResponse>(Path(), validateMultipleWirelessPointsRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public WirelessPointsBulkValidate.Index WirelessPointsBulkValidate()
        {
            return new WirelessPointsBulkValidate.Index(this);
        }
    }
}
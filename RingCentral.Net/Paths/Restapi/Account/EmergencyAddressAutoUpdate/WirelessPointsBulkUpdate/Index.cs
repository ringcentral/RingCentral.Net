using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkUpdate
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
            return $"{parent.Path()}/wireless-points-bulk-update";
        }

        /// <summary>
        ///     Updates wireless points in corporate map. The maximum number of
        ///     wireless points per request is 10 000; limitation for account is 70 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<UpdateMultipleWirelessPointsResponse> Post(
            UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<UpdateMultipleWirelessPointsResponse>(Path(), updateMultipleWirelessPointsRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public WirelessPointsBulkUpdate.Index WirelessPointsBulkUpdate()
        {
            return new WirelessPointsBulkUpdate.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkCreate
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
            return $"{parent.Path()}/wireless-points-bulk-create";
        }

        /// <summary>
        ///     Creates multiple wireless points in a corporate map. The maximum
        ///     number of wireless points per request is 10 000; limitation for account is
        ///     70 000.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<CreateMultipleWirelessPointsResponse> Post(
            CreateMultipleWirelessPointsRequest createMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CreateMultipleWirelessPointsResponse>(Path(), createMultipleWirelessPointsRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public WirelessPointsBulkCreate.Index WirelessPointsBulkCreate()
        {
            return new WirelessPointsBulkCreate.Index(this);
        }
    }
}
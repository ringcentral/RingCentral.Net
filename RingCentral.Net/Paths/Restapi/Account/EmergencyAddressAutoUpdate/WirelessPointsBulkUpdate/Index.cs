using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkUpdate
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
            return $"{parent.Path()}/wireless-points-bulk-update";
        }

        /// <summary>
        /// Operation: Update Multiple Wireless Points
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.UpdateMultipleWirelessPointsResponse> Post(
            RingCentral.UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.UpdateMultipleWirelessPointsResponse>(this.Path(),
                updateMultipleWirelessPointsRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkUpdate.Index WirelessPointsBulkUpdate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkUpdate.Index(this);
        }
    }
}
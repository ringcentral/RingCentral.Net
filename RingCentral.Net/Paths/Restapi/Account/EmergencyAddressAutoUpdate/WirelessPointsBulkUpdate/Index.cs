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
        /// Rate Limit Group: Heavy
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update
        /// </summary>
        public async Task<RingCentral.UpdateMultipleWirelessPointsResponse> Post(
            RingCentral.UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.UpdateMultipleWirelessPointsResponse>(this.Path(),
                updateMultipleWirelessPointsRequest, null, cancellationToken);
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
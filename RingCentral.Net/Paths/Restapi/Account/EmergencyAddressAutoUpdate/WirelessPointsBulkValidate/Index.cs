using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkValidate
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
            return $"{parent.Path()}/wireless-points-bulk-validate";
        }

        /// <summary>
        /// Operation: Validate Multiple Wireless Points
        /// Rate Limit Group: Heavy
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate
        /// </summary>
        public async Task<RingCentral.ValidateMultipleWirelessPointsResponse> Post(
            RingCentral.ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.ValidateMultipleWirelessPointsResponse>(this.Path(),
                validateMultipleWirelessPointsRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkValidate.Index WirelessPointsBulkValidate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkValidate.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkCreate
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
            return $"{parent.Path()}/wireless-points-bulk-create";
        }

        /// <summary>
        /// Creates multiple wireless points in corporate map. The maximum number of wireless points per request is 10 000; limitation for account is 70 000.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.CreateMultipleWirelessPointsResponse> Post(
            RingCentral.CreateMultipleWirelessPointsRequest createMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CreateMultipleWirelessPointsResponse>(this.Path(),
                createMultipleWirelessPointsRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkCreate.Index WirelessPointsBulkCreate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.WirelessPointsBulkCreate.Index(this);
        }
    }
}
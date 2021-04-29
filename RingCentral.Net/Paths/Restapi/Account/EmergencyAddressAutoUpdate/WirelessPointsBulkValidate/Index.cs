using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Validates wireless points before creation or update. The maximum number of wireless points per request is 10 000.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.ValidateMultipleWirelessPointsResponse> Post(
            RingCentral.ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ValidateMultipleWirelessPointsResponse>(this.Path(),
                validateMultipleWirelessPointsRequest, null, restRequestConfig);
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
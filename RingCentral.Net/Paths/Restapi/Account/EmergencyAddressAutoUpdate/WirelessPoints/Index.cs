using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints
{
    public partial class Index
    {
        public RestClient rc;
        public string pointId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string pointId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.pointId = pointId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && pointId != null)
            {
                return $"{parent.Path()}/wireless-points/{pointId}";
            }

            return $"{parent.Path()}/wireless-points";
        }

        /// <summary>
        /// Operation: Get Wireless Point List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointsList> List(ListWirelessPointsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.WirelessPointsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Wireless Point
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Post(RingCentral.CreateWirelessPoint createWirelessPoint,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.WirelessPointInfo>(this.Path(false), createWirelessPoint, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Wireless Point
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Get<RingCentral.WirelessPointInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Wireless Point
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Put(RingCentral.UpdateWirelessPoint updateWirelessPoint,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Put<RingCentral.WirelessPointInfo>(this.Path(), updateWirelessPoint, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Wireless Point
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints.Index WirelessPoints(string pointId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints.Index(this, pointId);
        }
    }
}
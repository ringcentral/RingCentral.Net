using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;
        public string pointId;

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
        /// Returns account wireless points configured and used for Automatic Location Updates feature.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointsList> List(
            RingCentral.ListWirelessPointsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.WirelessPointsList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a new wireless point in network configuration with the emergency address assigned.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points
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
        /// Returns the specified wireless access point of a corporate map with the emergency address assigned.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (pointId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(pointId));
            }

            return await rc.Get<RingCentral.WirelessPointInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the specified wireless access point of a corporate map by ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Put(RingCentral.UpdateWirelessPoint updateWirelessPoint,
            RestRequestConfig restRequestConfig = null)
        {
            if (pointId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(pointId));
            }

            return await rc.Put<RingCentral.WirelessPointInfo>(this.Path(), updateWirelessPoint, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes wireless point(s) of a corporate map by ID(s).
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (pointId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(pointId));
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
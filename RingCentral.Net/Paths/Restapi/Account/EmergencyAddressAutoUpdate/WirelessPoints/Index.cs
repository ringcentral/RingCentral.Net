using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints
{
    public class Index
    {
        public EmergencyAddressAutoUpdate.Index parent;
        public string pointId;
        public RestClient rc;

        public Index(EmergencyAddressAutoUpdate.Index parent, string pointId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.pointId = pointId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && pointId != null) return $"{parent.Path()}/wireless-points/{pointId}";

            return $"{parent.Path()}/wireless-points";
        }

        /// <summary>
        ///     Returns account wireless points configured and used for Automatic Location Updates feature.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<WirelessPointsList> List(
            ListWirelessPointsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<WirelessPointsList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new wireless point in network configuration with the emergency address assigned.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<WirelessPointInfo> Post(CreateWirelessPoint createWirelessPoint,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<WirelessPointInfo>(Path(false), createWirelessPoint, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the specified wireless access point of a corporate map with the emergency address assigned.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<WirelessPointInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<WirelessPointInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified wireless access point of a corporate map by ID.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<WirelessPointInfo> Put(UpdateWirelessPoint updateWirelessPoint,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<WirelessPointInfo>(Path(), updateWirelessPoint, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes wireless point(s) of a corporate map by ID(s).
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public WirelessPoints.Index WirelessPoints(string pointId = null)
        {
            return new WirelessPoints.Index(this, pointId);
        }
    }
}
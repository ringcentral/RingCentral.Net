using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyLocations
{
    public class Index
    {
        public string locationId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string locationId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.locationId = locationId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && locationId != null) return $"{parent.Path()}/emergency-locations/{locationId}";
            return $"{parent.Path()}/emergency-locations";
        }

        /// <summary>
        ///     Returns emergency response locations for the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<EmergencyLocationsResource> List(ListEmergencyLocationsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<EmergencyLocationsResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new emergency response location for a company.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Post(
            EmergencyLocationInfoRequest emergencyLocationInfoRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CommonEmergencyLocationResource>(Path(false), emergencyLocationInfoRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns emergency response location by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Get(ReadEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Get<CommonEmergencyLocationResource>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates the specified emergency response location.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Put(
            EmergencyLocationInfoRequest emergencyLocationInfoRequest, RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Put<CommonEmergencyLocationResource>(Path(), emergencyLocationInfoRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes the specified emergency response location.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(DeleteEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Delete<string>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public EmergencyLocations.Index EmergencyLocations(string locationId = null)
        {
            return new EmergencyLocations.Index(this, locationId);
        }
    }
}
using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.EmergencyLocations
{
    public class Index
    {
        public string locationId;
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent, string locationId = null)
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
        ///     Returns a list of emergency response locations available for the particular extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<EmergencyLocationsResource> List(GetExtensionEmergencyLocationsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<EmergencyLocationsResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a personal emergency response location for the current user.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EmergencyFramework
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Post(
            CreateUserEmergencyLocationRequest createUserEmergencyLocationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CommonEmergencyLocationResource>(Path(false), createUserEmergencyLocationRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a personal emergency response location for the current user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Get<CommonEmergencyLocationResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a personal emergency response location by the current user or admin.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: EmergencyFramework
        /// </summary>
        public async Task<CommonEmergencyLocationResource> Put(
            EmergencyLocationInfoRequest emergencyLocationInfoRequest, RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Put<CommonEmergencyLocationResource>(Path(), emergencyLocationInfoRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes a personal emergency response location by ID by
        ///     the current user or admin. Multiple personal emergency response
        ///     locations can be deleted by single API call.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditAccounts
        ///     User Permission: EmergencyFramework
        /// </summary>
        public async Task<string> Delete(DeleteExtensionEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null) throw new ArgumentException("Parameter cannot be null", nameof(locationId));
            return await rc.Delete<string>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public EmergencyLocations.Index EmergencyLocations(string locationId = null)
        {
            return new EmergencyLocations.Index(this, locationId);
        }
    }
}
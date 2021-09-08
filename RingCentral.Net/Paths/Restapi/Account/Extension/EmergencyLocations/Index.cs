using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.EmergencyLocations
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string locationId;

        public Index(Restapi.Account.Extension.Index parent, string locationId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.locationId = locationId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && locationId != null)
            {
                return $"{parent.Path()}/emergency-locations/{locationId}";
            }

            return $"{parent.Path()}/emergency-locations";
        }

        /// <summary>
        /// Returns a list of emergency response locations available for the current user extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.EmergencyLocationsResource> Get(
            RingCentral.GetExtensionEmergencyLocationsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.EmergencyLocationsResource>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Creates a personal emergency response location for the current user.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Heavy
        /// App Permission: ReadAccounts
        /// User Permission: EmergencyFramework
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Post(
            RingCentral.CreateUserEmergencyLocationRequest createUserEmergencyLocationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.EmergencyLocationInfo>(this.Path(false),
                createUserEmergencyLocationRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Updates a personal emergency response location by the current user or admin.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        /// Rate Limit Group: Light
        /// App Permission: EditExtensions
        /// User Permission: EmergencyFramework
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Put(
            RingCentral.EmergencyLocationInfo emergencyLocationInfo, RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(locationId));
            }

            return await rc.Put<RingCentral.EmergencyLocationInfo>(this.Path(), emergencyLocationInfo, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes a personal emergency response location by ID by the current user or admin. Multiple personal emergency response locations can be deleted by one API call
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EmergencyFramework
        /// </summary>
        public async Task<string> Delete(RingCentral.DeleteExtensionEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (locationId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(locationId));
            }

            return await rc.Delete<string>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.EmergencyLocations.Index EmergencyLocations(string locationId = null)
        {
            return new Restapi.Account.Extension.EmergencyLocations.Index(this, locationId);
        }
    }
}
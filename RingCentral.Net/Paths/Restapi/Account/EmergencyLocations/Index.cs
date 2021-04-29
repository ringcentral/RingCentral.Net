using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyLocations
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string locationId;

        public Index(Restapi.Account.Index parent, string locationId = null)
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
        /// Returns emergency response locations of the current account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationList> List(
            RingCentral.ListEmergencyLocationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.EmergencyLocationList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Add Emergency Location
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Post(RingCentral.EmergencyLocationInfoRequest emergencyLocationInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(false), emergencyLocationInfoRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Returns emergency response location by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.EmergencyLocationInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the specified emergency response location.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Put(
            RingCentral.EmergencyLocationInfoRequest emergencyLocationInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.EmergencyLocationInfo>(this.Path(), emergencyLocationInfoRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes the specified emergency response location.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RingCentral.DeleteEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.EmergencyLocations.Index EmergencyLocations(string locationId = null)
        {
            return new Restapi.Account.EmergencyLocations.Index(this, locationId);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyLocations
{
    public partial class Index
    {
        public RestClient rc;
        public string locationId;
        public Restapi.Account.Index parent;

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
        /// Operation: Get Emergency Location List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationList> List(ListEmergencyLocationsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.EmergencyLocationList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Add Emergency Location
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-locations
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
        /// Operation: Get Emergency Location
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.locationId == null)
            {
                throw new System.ArgumentNullException("locationId");
            }

            return await rc.Get<RingCentral.EmergencyLocationInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Emergency Location
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Put(
            RingCentral.EmergencyLocationInfoRequest emergencyLocationInfoRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.locationId == null)
            {
                throw new System.ArgumentNullException("locationId");
            }

            return await rc.Put<RingCentral.EmergencyLocationInfo>(this.Path(), emergencyLocationInfoRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Emergency Location
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(DeleteEmergencyLocationParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.locationId == null)
            {
                throw new System.ArgumentNullException("locationId");
            }

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
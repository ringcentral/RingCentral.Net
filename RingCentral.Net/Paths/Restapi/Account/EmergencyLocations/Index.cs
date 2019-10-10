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
        /// Operation: Add Emergency Location
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-locations
        /// </summary>
        public async Task<string> Post(RingCentral.EmergencyLocationInfoRequest emergencyLocationInfoRequest)
        {
            return await rc.Post<string>(this.Path(false), emergencyLocationInfoRequest);
        }

        /// <summary>
        /// Operation: Get Emergency Location List
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-locations
        /// </summary>
        public async Task<RingCentral.EmergencyLocationList> List(ListEmergencyLocationsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.EmergencyLocationList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Emergency Location
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-locations/{locationId}
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Get()
        {
            if (this.locationId == null)
            {
                throw new System.ArgumentNullException("locationId");
            }

            return await rc.Get<RingCentral.EmergencyLocationInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Emergency Location
        /// Http Put /restapi/v1.0/account/{accountId}/emergency-locations/{locationId}
        /// </summary>
        public async Task<RingCentral.EmergencyLocationInfo> Put(
            RingCentral.EmergencyLocationInfoRequest emergencyLocationInfoRequest)
        {
            if (this.locationId == null)
            {
                throw new System.ArgumentNullException("locationId");
            }

            return await rc.Put<RingCentral.EmergencyLocationInfo>(this.Path(), emergencyLocationInfoRequest);
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
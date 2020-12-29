using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.EmergencyLocations
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/emergency-locations";
        }

        /// <summary>
        /// Operation: Get User Emergency Location List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.UserEmergencyLocationList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserEmergencyLocationList>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.EmergencyLocations.Index EmergencyLocations()
        {
            return new Restapi.Account.Extension.EmergencyLocations.Index(this);
        }
    }
}
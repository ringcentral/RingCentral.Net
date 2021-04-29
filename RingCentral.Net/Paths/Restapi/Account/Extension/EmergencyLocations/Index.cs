using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Returns a list of emergency response locations available for the current user extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
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
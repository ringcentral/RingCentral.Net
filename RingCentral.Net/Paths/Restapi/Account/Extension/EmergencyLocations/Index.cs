using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.EmergencyLocations
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/emergency-locations";
        }

        /// <summary>
        ///     Returns a list of emergency response locations available for the current user extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<UserEmergencyLocationList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserEmergencyLocationList>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public EmergencyLocations.Index EmergencyLocations()
        {
            return new EmergencyLocations.Index(this);
        }
    }
}
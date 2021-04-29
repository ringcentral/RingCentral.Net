using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
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
            return $"{parent.Path()}/authz-profile";
        }

        /// <summary>
        /// Returns a list of user permissions granted at authorization procedure. Please note: Some permissions may be restricted by extension type.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.AuthProfileResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AuthProfileResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AuthzProfile.Index AuthzProfile()
        {
            return new Restapi.Account.Extension.AuthzProfile.Index(this);
        }
    }
}
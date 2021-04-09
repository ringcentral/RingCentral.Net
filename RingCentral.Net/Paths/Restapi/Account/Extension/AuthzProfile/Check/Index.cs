using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile.Check
{
    public class Index
    {
        public AuthzProfile.Index parent;
        public RestClient rc;

        public Index(AuthzProfile.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/check";
        }

        /// <summary>
        ///     Checks if a certain user permission is activated for a particular extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile/check
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<AuthProfileCheckResource> Get(
            CheckUserPermissionParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AuthProfileCheckResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
{
    public partial class Index
    {
        public Check.Index Check()
        {
            return new Check.Index(this);
        }
    }
}
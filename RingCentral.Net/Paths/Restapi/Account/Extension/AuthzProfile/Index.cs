using System.Threading.Tasks;

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
        /// Operation: Get User Permissions
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile
        /// </summary>
        public async Task<RingCentral.AuthProfileResource> Get()
        {
            return await rc.Get<RingCentral.AuthProfileResource>(this.Path());
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
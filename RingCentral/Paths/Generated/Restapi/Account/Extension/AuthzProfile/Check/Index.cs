using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile.Check
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.AuthzProfile.Index parent;

        public Index(Restapi.Account.Extension.AuthzProfile.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/check";
        }

        public async Task<RingCentral.AuthProfileCheckResource> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.AuthProfileCheckResource>(this.Path(), queryParams);
        }

        public async Task<RingCentral.AuthProfileCheckResource> Get(object queryParams)
        {
            return await rc.Get<RingCentral.AuthProfileCheckResource>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        public string permissionId;

        public string targetExtensionId;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
{
    public partial class Index
    {
        public Restapi.Account.Extension.AuthzProfile.Check.Index Check()
        {
            return new Restapi.Account.Extension.AuthzProfile.Check.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities.Import
{
    public class Index
    {
        public Identities.Index parent;
        public RestClient rc;

        public Index(Identities.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/import";
        }

        /// <summary>
        ///     Import an identity from given identifier.
        ///     Available only for Email channels.
        ///     HTTP Method: post
        ///     Endpoint: /cx/social-messaging/v1/identities/import
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> Post(ImportIdentityRequest importIdentityRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), importIdentityRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities
{
    public partial class Index
    {
        public Import.Index Import()
        {
            return new Import.Index(this);
        }
    }
}
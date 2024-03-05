using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities.Anonymize
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
            return $"{parent.Path()}/anonymize";
        }

        /// <summary>
        ///     Anonymizes an Identity.
        ///     HTTP Method: post
        ///     Endpoint: /cx/social-messaging/v1/identities/{identityId}/anonymize
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities
{
    public partial class Index
    {
        public Anonymize.Index Anonymize()
        {
            return new Anonymize.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities.Deanonymize
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
            return $"{parent.Path()}/deanonymize";
        }

        /// <summary>
        ///     Flag Identity for deanonymization.
        ///     The next time a content from this Identity will be imported, the identity will be imported again.
        ///     HTTP Method: post
        ///     Endpoint: /cx/social-messaging/v1/identities/{identityId}/deanonymize
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
        public Deanonymize.Index Deanonymize()
        {
            return new Deanonymize.Index(this);
        }
    }
}
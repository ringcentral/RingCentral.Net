using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities
{
    public class Index
    {
        public string identityId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string identityId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.identityId = identityId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && identityId != null) return $"{parent.Path()}/identities/{identityId}";
            return $"{parent.Path()}/identities";
        }

        /// <summary>
        ///     Returns a list of identities filtered by creation date. The default order is descending.
        ///     The account context of this request is determined by the RC Account ID associated with
        ///     the access token provided in the Authorization header.
        ///     The query parameters provided will be considered an AND operation to filter the list.
        ///     A query parameter which is not specified or provided with the null value will be ignored.
        ///     HTTP Method: get
        ///     Endpoint: /cx/social-messaging/v1/identities
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> List(ListSocialMessagingIdentitiesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns an identity by ID specified in path.
        ///     HTTP Method: get
        ///     Endpoint: /cx/social-messaging/v1/identities/{identityId}
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            if (identityId == null) throw new ArgumentException("Parameter cannot be null", nameof(identityId));
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Cx.SocialMessaging.V1
{
    public partial class Index
    {
        public Identities.Index Identities(string identityId = null)
        {
            return new Identities.Index(this, identityId);
        }
    }
}
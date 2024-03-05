using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Identities
{
    public partial class Index
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
        ///     List identities by creation date. The default order is descending.
        ///     The account context of this request is determined by the RC Account Id associated with the access token provided
        ///     in the Authorization header.
        ///     The query parameters provided shall be considered an AND operation to filter the list.
        ///     A query parameter not specified or a query parameter provided with no value is treated as not required for
        ///     filtering the list.
        ///     HTTP Method: get
        ///     Endpoint: /cx/social-messaging/v1/identities
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> List(SocMsgListIdentitiesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Renders an identity from given id.
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
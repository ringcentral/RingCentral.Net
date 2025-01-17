using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Schemas
{
    public class Index
    {
        public Scim.Index parent;
        public RestClient rc;
        public string uri;

        public Index(Scim.Index parent, string uri = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.uri = uri;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && uri != null) return $"{parent.Path()}/Schemas/{uri}";

            return $"{parent.Path()}/Schemas";
        }

        /// <summary>
        ///     Returns the list of schemas
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Schemas
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimSchemaSearchResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ScimSchemaSearchResponse>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns SCIM schema
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/Schemas/{uri}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimSchemaResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (uri == null) throw new ArgumentException("Parameter cannot be null", nameof(uri));

            return await rc.Get<ScimSchemaResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Schemas.Index Schemas(string uri = null)
        {
            return new Schemas.Index(this, uri);
        }
    }
}
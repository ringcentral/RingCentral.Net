using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Scim.Schemas
{
    public partial class Index
    {
        public RestClient rc;
public Scim.Index parent;
public string uri;
public Index(Scim.Index parent, string uri = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.uri = uri;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && uri != null)
            {
                return $"{parent.Path()}/Schemas/{uri}";
            }
            return $"{parent.Path()}/Schemas";
        }
        /// <summary>
        /// Returns the list of schemas
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Schemas
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.ScimSchemaSearchResponse> List(RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.ScimSchemaSearchResponse>(this.Path(false), null, restRequestConfig);
  }

        /// <summary>
        /// Returns SCIM schema
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/Schemas/{uri}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.ScimSchemaResponse> Get(RestRequestConfig restRequestConfig = null)
  {
if (uri == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(uri));
    }return await rc.Get<RingCentral.ScimSchemaResponse>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Schemas.Index Schemas(string uri = null)
        {
            return new Scim.Schemas.Index(this, uri);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Scim.ResourceTypes
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Index parent;
        public string type;
        public Index(Scim.Index parent, string type = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.type = type;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && type != null)
            {
                return $"{parent.Path()}/ResourceTypes/{type}";
            }
            return $"{parent.Path()}/ResourceTypes";
        }
        /// <summary>
        /// Returns the list of supported SCIM resource types
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/ResourceTypes
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.ScimResourceTypeSearchResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ScimResourceTypeSearchResponse>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns resource type by ID
        /// HTTP Method: get
        /// Endpoint: /scim/{version}/ResourceTypes/{type}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
        public async Task<RingCentral.ScimResourceTypeResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (type == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(type));
            }
            return await rc.Get<RingCentral.ScimResourceTypeResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.ResourceTypes.Index ResourceTypes(string type = null)
        {
            return new Scim.ResourceTypes.Index(this, type);
        }
    }
}
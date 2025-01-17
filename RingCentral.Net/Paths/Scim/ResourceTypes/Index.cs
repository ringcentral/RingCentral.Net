using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.ResourceTypes
{
    public class Index
    {
        public Scim.Index parent;
        public RestClient rc;
        public string type;

        public Index(Scim.Index parent, string type = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.type = type;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && type != null) return $"{parent.Path()}/ResourceTypes/{type}";

            return $"{parent.Path()}/ResourceTypes";
        }

        /// <summary>
        ///     Returns the list of supported SCIM resource types
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/ResourceTypes
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimResourceTypeSearchResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ScimResourceTypeSearchResponse>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns resource type by ID
        ///     HTTP Method: get
        ///     Endpoint: /scim/{version}/ResourceTypes/{type}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<ScimResourceTypeResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (type == null) throw new ArgumentException("Parameter cannot be null", nameof(type));

            return await rc.Get<ScimResourceTypeResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public ResourceTypes.Index ResourceTypes(string type = null)
        {
            return new ResourceTypes.Index(this, type);
        }
    }
}
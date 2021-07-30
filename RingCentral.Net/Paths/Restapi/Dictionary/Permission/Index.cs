using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Permission
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string permissionId;

        public Index(Restapi.Dictionary.Index parent, string permissionId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.permissionId = permissionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && permissionId != null)
            {
                return $"{parent.Path()}/permission/{permissionId}";
            }

            return $"{parent.Path()}/permission";
        }

        /// <summary>
        /// Returns a list of extension user permissions.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/permission
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.PermissionCollectionResource> List(
            RingCentral.ListPermissionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PermissionCollectionResource>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Returns user permission by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/permission/{permissionId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.PermissionResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (permissionId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(permissionId));
            }

            return await rc.Get<RingCentral.PermissionResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Permission.Index Permission(string permissionId = null)
        {
            return new Restapi.Dictionary.Permission.Index(this, permissionId);
        }
    }
}
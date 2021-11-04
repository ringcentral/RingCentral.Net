using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Permission
{
    public class Index
    {
        public Dictionary.Index parent;
        public string permissionId;
        public RestClient rc;

        public Index(Dictionary.Index parent, string permissionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.permissionId = permissionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && permissionId != null) return $"{parent.Path()}/permission/{permissionId}";

            return $"{parent.Path()}/permission";
        }

        /// <summary>
        ///     Returns a list of extension user permissions.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/permission
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PermissionCollectionResource> List(
            ListPermissionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<PermissionCollectionResource>(Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns user permission by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/permission/{permissionId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PermissionResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (permissionId == null) throw new ArgumentException("Parameter cannot be null", nameof(permissionId));

            return await rc.Get<PermissionResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Permission.Index Permission(string permissionId = null)
        {
            return new Permission.Index(this, permissionId);
        }
    }
}
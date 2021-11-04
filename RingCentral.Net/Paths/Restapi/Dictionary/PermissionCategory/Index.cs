using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.PermissionCategory
{
    public class Index
    {
        public Dictionary.Index parent;
        public string permissionCategoryId;
        public RestClient rc;

        public Index(Dictionary.Index parent, string permissionCategoryId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.permissionCategoryId = permissionCategoryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && permissionCategoryId != null)
                return $"{parent.Path()}/permission-category/{permissionCategoryId}";

            return $"{parent.Path()}/permission-category";
        }

        /// <summary>
        ///     Returns the list of permission categories.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/permission-category
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PermissionCategoryCollectionResource> List(
            ListPermissionCategoriesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<PermissionCategoryCollectionResource>(Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns permission category by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/permission-category/{permissionCategoryId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<PermissionCategoryResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (permissionCategoryId == null)
                throw new ArgumentException("Parameter cannot be null", nameof(permissionCategoryId));

            return await rc.Get<PermissionCategoryResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public PermissionCategory.Index PermissionCategory(string permissionCategoryId = null)
        {
            return new PermissionCategory.Index(this, permissionCategoryId);
        }
    }
}
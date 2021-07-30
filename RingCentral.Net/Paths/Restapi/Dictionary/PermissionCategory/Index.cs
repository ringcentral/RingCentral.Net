using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.PermissionCategory
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string permissionCategoryId;

        public Index(Restapi.Dictionary.Index parent, string permissionCategoryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.permissionCategoryId = permissionCategoryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && permissionCategoryId != null)
            {
                return $"{parent.Path()}/permission-category/{permissionCategoryId}";
            }

            return $"{parent.Path()}/permission-category";
        }

        /// <summary>
        /// Returns the list of permission categories.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/permission-category
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.PermissionCategoryCollectionResource> List(
            RingCentral.ListPermissionCategoriesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PermissionCategoryCollectionResource>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Returns permission category by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/permission-category/{permissionCategoryId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.PermissionCategoryResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (permissionCategoryId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(permissionCategoryId));
            }

            return await rc.Get<RingCentral.PermissionCategoryResource>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.PermissionCategory.Index PermissionCategory(string permissionCategoryId = null)
        {
            return new Restapi.Dictionary.PermissionCategory.Index(this, permissionCategoryId);
        }
    }
}
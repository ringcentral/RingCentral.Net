using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/extension-bulk-update";
        }

        /// <summary>
        ///     Updates multiple extensions at once. Maximum 500 extensions can be updated per request.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension-bulk-update
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: EditExtensionInfo
        /// </summary>
        public async Task<ExtensionBulkUpdateTaskResource> Post(
            ExtensionBulkUpdateRequest extensionBulkUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ExtensionBulkUpdateTaskResource>(Path(), extensionBulkUpdateRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public ExtensionBulkUpdate.Index ExtensionBulkUpdate()
        {
            return new ExtensionBulkUpdate.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ExtensionBulkUpdate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/extension-bulk-update";
        }

        /// <summary>
        /// Updates multiple extensions at once. Maximum 500 extensions can be updated per request.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension-bulk-update
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EditExtensionInfo
        /// </summary>
        public async Task<RingCentral.ExtensionBulkUpdateTaskResource> Post(
            RingCentral.ExtensionBulkUpdateRequest extensionBulkUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ExtensionBulkUpdateTaskResource>(this.Path(), extensionBulkUpdateRequest,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ExtensionBulkUpdate.Index ExtensionBulkUpdate()
        {
            return new Restapi.Account.ExtensionBulkUpdate.Index(this);
        }
    }
}
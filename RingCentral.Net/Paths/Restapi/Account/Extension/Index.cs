using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public RestClient rc;
        public string extensionId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string extensionId = "~")
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.extensionId = extensionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null)
            {
                return $"{parent.Path()}/extension/{extensionId}";
            }

            return $"{parent.Path()}/extension";
        }

        /// <summary>
        /// Returns the list of extensions created for a particular account. All types of extensions are included in this list.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.GetExtensionListResponse> List(ListExtensionsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetExtensionListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates an extension.
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: AddRemoveUsers
        /// </summary>
        public async Task<RingCentral.ExtensionCreationResponse> Post(
            RingCentral.ExtensionCreationRequest extensionCreationRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.ExtensionCreationResponse>(this.Path(false), extensionCreationRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns basic information about a particular extension.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Get<RingCentral.GetExtensionInfoResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates user settings.
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserInfo OR EditUserCredentials
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Put(
            RingCentral.ExtensionUpdateRequest extensionUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Put<RingCentral.GetExtensionInfoResponse>(this.Path(), extensionUpdateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes extension(s) by ID(s). When an extension is being deleted the default API behaviour is as follows: ⋅⋅* user's direct numbers are preserved by becoming additional company numbers; ⋅⋅* user's digital lines (both device & associated phone number) are deleted. You can change this behaviour using the filters: ..* create unassigned extensions for each digital line of the deleted extension by setting the query parameter `savePhoneLines` to `true` in request path; ..* remove direct numbers of the deleted extension by setting the query parameter `savePhoneNumbers` to `false` in request path
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: AddRemoveUsers
        /// </summary>
        public async Task<string> Delete(DeleteExtensionParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Delete<string>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Extension.Index Extension(string extensionId = "~")
        {
            return new Restapi.Account.Extension.Index(this, extensionId);
        }
    }
}
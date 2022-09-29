using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public string extensionId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string extensionId = "~")
        {
            this.parent = parent;
            rc = parent.rc;
            this.extensionId = extensionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && extensionId != null) return $"{parent.Path()}/extension/{extensionId}";
            return $"{parent.Path()}/extension";
        }

        /// <summary>
        ///     Returns the list of extensions created for a particular account. All types of extensions are included in this list.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<GetExtensionListResponse> List(ListExtensionsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetExtensionListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates an extension.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: AddRemoveUsers
        /// </summary>
        public async Task<ExtensionCreationResponse> Post(ExtensionCreationRequest extensionCreationRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<ExtensionCreationResponse>(Path(false), extensionCreationRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns basic information about a particular extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<GetExtensionInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (extensionId == null) throw new ArgumentException("Parameter cannot be null", nameof(extensionId));
            return await rc.Get<GetExtensionInfoResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates user settings.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserInfo OR EditUserCredentials
        /// </summary>
        public async Task<GetExtensionInfoResponse> Put(ExtensionUpdateRequest extensionUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (extensionId == null) throw new ArgumentException("Parameter cannot be null", nameof(extensionId));
            return await rc.Put<GetExtensionInfoResponse>(Path(), extensionUpdateRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes extension(s) by ID(s). When an extension is being deleted the default API behavior is as follows: ⋅⋅*
        ///     user's direct numbers are preserved by becoming additional company numbers; ⋅⋅* user's digital lines (both device &
        ///     associated phone number) are deleted. You can change this behavior using the filters: ..* create unassigned
        ///     extensions for each digital line of the deleted extension by setting the query parameter `savePhoneLines` to `true`
        ///     in request path; ..* remove direct numbers of the deleted extension by setting the query parameter
        ///     `savePhoneNumbers` to `false` in request path
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: AddRemoveUsers
        /// </summary>
        public async Task<string> Delete(DeleteExtensionParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (extensionId == null) throw new ArgumentException("Parameter cannot be null", nameof(extensionId));
            return await rc.Delete<string>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Extension.Index Extension(string extensionId = "~")
        {
            return new Extension.Index(this, extensionId);
        }
    }
}
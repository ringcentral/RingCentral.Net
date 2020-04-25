using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get Extension List
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/account/{accountId}/extension
        /// </summary>
        public async Task<RingCentral.GetExtensionListResponse> List(ListExtensionsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetExtensionListResponse>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Extension
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/account/{accountId}/extension
        /// </summary>
        public async Task<RingCentral.ExtensionCreationResponse> Post(
            RingCentral.ExtensionCreationRequest extensionCreationRequest, CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.ExtensionCreationResponse>(this.Path(false), extensionCreationRequest,
                null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Extension
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Get<RingCentral.GetExtensionInfoResponse>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Extension
        /// Rate Limit Group: Medium
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Put(
            RingCentral.ExtensionUpdateRequest extensionUpdateRequest, CancellationToken? cancellationToken = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Put<RingCentral.GetExtensionInfoResponse>(this.Path(), extensionUpdateRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Extension
        /// Rate Limit Group: Medium
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<string> Delete(DeleteExtensionParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Delete<string>(this.Path(), queryParams, cancellationToken);
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
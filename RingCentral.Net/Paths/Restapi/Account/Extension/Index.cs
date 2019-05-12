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
        /// Operation: Get Extension List
        /// Http Get /restapi/v1.0/account/{accountId}/extension
        /// </summary>
        public async Task<RingCentral.GetExtensionListResponse> List(ListExtensionsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetExtensionListResponse>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Create Extension
        /// Http Post /restapi/v1.0/account/{accountId}/extension
        /// </summary>
        public async Task<RingCentral.ExtensionCreationResponse> Post(
            RingCentral.ExtensionCreationRequest extensionCreationRequest)
        {
            return await rc.Post<RingCentral.ExtensionCreationResponse>(this.Path(false), extensionCreationRequest);
        }

        /// <summary>
        /// Operation: Get Extension
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Get()
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Get<RingCentral.GetExtensionInfoResponse>(this.Path());
        }

        /// <summary>
        /// Operation: Update Extension
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<RingCentral.GetExtensionInfoResponse> Put(
            RingCentral.ExtensionUpdateRequest extensionUpdateRequest)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Put<RingCentral.GetExtensionInfoResponse>(this.Path(), extensionUpdateRequest);
        }

        /// <summary>
        /// Operation: Delete Extension
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Delete<string>(this.Path());
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
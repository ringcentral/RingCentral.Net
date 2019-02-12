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

        public async Task<RingCentral.GetExtensionListResponse> List()
        {
            return await rc.Get<RingCentral.GetExtensionListResponse>(this.Path(false));
        }

        public async Task<RingCentral.ExtensionCreationResponse> Post(
            RingCentral.ExtensionCreationRequest extensionCreationRequest)
        {
            return await rc.Post<RingCentral.ExtensionCreationResponse>(this.Path(false), extensionCreationRequest);
        }

        public async Task<RingCentral.GetExtensionInfoResponse> Get()
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Get<RingCentral.GetExtensionInfoResponse>(this.Path());
        }

        public async Task<RingCentral.GetExtensionInfoResponse> Put(
            RingCentral.ExtensionUpdateRequest extensionUpdateRequest)
        {
            if (this.extensionId == null)
            {
                throw new System.ArgumentNullException("extensionId");
            }

            return await rc.Put<RingCentral.GetExtensionInfoResponse>(this.Path(), extensionUpdateRequest);
        }

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
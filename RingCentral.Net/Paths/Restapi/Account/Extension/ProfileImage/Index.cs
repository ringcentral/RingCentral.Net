using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.ProfileImage
{
    public partial class Index
    {
        public RestClient rc;
        public string scaleSize;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string scaleSize = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.scaleSize = scaleSize;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && scaleSize != null)
            {
                return $"{parent.Path()}/profile-image/{scaleSize}";
            }

            return $"{parent.Path()}/profile-image";
        }

        /// <summary>
        /// Operation: Get User Profile Image
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Medium
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadExtensions
        /// </summary>
        public async Task<byte[]> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<byte[]>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Upload User Profile Image
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditExtensions
        /// User Permission Required: EditUserInfo
        /// </summary>
        public async Task<string> Post(CreateUserProfileImageRequest createUserProfileImageRequest,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserProfileImageRequest);
            return await rc.Post<string>(this.Path(false), multipartFormDataContent, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update User Profile Image
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Heavy
        /// App Permission Required: EditExtensions
        /// User Permission Required: EditUserInfo
        /// </summary>
        public async Task<string> Put(UpdateUserProfileImageRequest updateUserProfileImageRequest,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(updateUserProfileImageRequest);
            return await rc.Put<string>(this.Path(false), multipartFormDataContent, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Scaled User Profile Image
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}
        /// Rate Limit Group: Light
        /// App Permission Required: ReadAccounts
        /// User Permission Required: ReadExtensions
        /// </summary>
        public async Task<byte[]> Get(CancellationToken? cancellationToken = null)
        {
            if (this.scaleSize == null)
            {
                throw new System.ArgumentNullException("scaleSize");
            }

            return await rc.Get<byte[]>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.ProfileImage.Index ProfileImage(string scaleSize = null)
        {
            return new Restapi.Account.Extension.ProfileImage.Index(this, scaleSize);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.ProfileImage
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string scaleSize;

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
        /// Returns a profile image of an extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<byte[]> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Uploads the extension profile image.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EditUserInfo
        /// </summary>
        public async Task<string> Post(RingCentral.CreateUserProfileImageRequest createUserProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserProfileImageRequest);
            return await rc.Post<string>(this.Path(false), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        /// Updates the extension profile image
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        /// Rate Limit Group: Heavy
        /// App Permission: EditExtensions
        /// User Permission: EditUserInfo
        /// </summary>
        public async Task<string> Put(RingCentral.UpdateUserProfileImageRequest updateUserProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(updateUserProfileImageRequest);
            return await rc.Put<string>(this.Path(false), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        /// Returns scaled profile image of an extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            if (scaleSize == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(scaleSize));
            }

            return await rc.Get<byte[]>(this.Path(), null, restRequestConfig);
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
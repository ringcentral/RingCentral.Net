using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.ProfileImage
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;
        public string scaleSize;

        public Index(Extension.Index parent, string scaleSize = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.scaleSize = scaleSize;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && scaleSize != null) return $"{parent.Path()}/profile-image/{scaleSize}";
            return $"{parent.Path()}/profile-image";
        }

        /// <summary>
        ///     Returns a profile image of an extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<byte[]> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Uploads the extension profile image.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserInfo
        /// </summary>
        public async Task<string> Post(CreateUserProfileImageRequest createUserProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserProfileImageRequest);
            return await rc.Post<string>(Path(false), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the extension profile image
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image
        ///     Rate Limit Group: Heavy
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserInfo
        /// </summary>
        public async Task<string> Put(UpdateUserProfileImageRequest updateUserProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(updateUserProfileImageRequest);
            return await rc.Put<string>(Path(false), multipartFormDataContent, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns scaled profile image of an extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<byte[]> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<byte[]>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public ProfileImage.Index ProfileImage(string scaleSize = null)
        {
            return new ProfileImage.Index(this, scaleSize);
        }
    }
}
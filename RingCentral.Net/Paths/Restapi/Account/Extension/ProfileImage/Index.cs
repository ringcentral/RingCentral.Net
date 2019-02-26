using System.Threading.Tasks;

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

        // Operation: downloadProfileImage
        public async Task<byte[]> List()
        {
            return await rc.Get<byte[]>(this.Path(false));
        }

        // Operation: uploadProfileImage
        public async Task<byte[]> Post(UploadProfileImageRequest uploadProfileImageRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(uploadProfileImageRequest);
            return await rc.Post<byte[]>(this.Path(false), multipartFormDataContent);
        }

        // Operation: updateProfileImage
        public async Task<byte[]> Put(UpdateProfileImageRequest updateProfileImageRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(updateProfileImageRequest);
            return await rc.Post<byte[]>(this.Path(false), multipartFormDataContent);
        }

        // Operation: downloadScaledPofileImage
        public async Task<byte[]> Get()
        {
            if (this.scaleSize == null)
            {
                throw new System.ArgumentNullException("scaleSize");
            }

            return await rc.Get<byte[]>(this.Path());
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
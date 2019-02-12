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

        public async Task<RingCentral.Binary> List()
        {
            return await rc.Get<RingCentral.Binary>(this.Path(false));
        }

        public async Task<RingCentral.Binary> Post()
        {
            return await rc.Post<RingCentral.Binary>(this.Path(false));
        }

        public async Task<RingCentral.Binary> Put()
        {
            return await rc.Put<RingCentral.Binary>(this.Path(false));
        }

        public async Task<RingCentral.Binary> Get()
        {
            if (this.scaleSize == null)
            {
                throw new System.ArgumentNullException("scaleSize");
            }

            return await rc.Get<RingCentral.Binary>(this.Path());
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
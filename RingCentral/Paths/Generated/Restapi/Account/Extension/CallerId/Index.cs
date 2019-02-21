using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerId
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/caller-id";
        }

        public async Task<RingCentral.ExtensionCallerIdInfo> Get()
        {
            return await rc.Get<RingCentral.ExtensionCallerIdInfo>(this.Path());
        }

        public async Task<RingCentral.ExtensionCallerIdInfo> Put(
            RingCentral.ExtensionCallerIdInfo extensionCallerIdInfo)
        {
            return await rc.Put<RingCentral.ExtensionCallerIdInfo>(this.Path(), extensionCallerIdInfo);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerId.Index CallerId()
        {
            return new Restapi.Account.Extension.CallerId.Index(this);
        }
    }
}
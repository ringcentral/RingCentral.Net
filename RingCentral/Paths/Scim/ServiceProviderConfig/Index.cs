using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.ServiceProviderConfig
{
    public class Index
    {
        public Scim.Index parent;
        public RestClient rc;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return parent.Path() + "/ServiceProviderConfig";
        }

        public async Task<RingCentral.ServiceProviderConfig> Get()
        {
            return await rc.Get<RingCentral.ServiceProviderConfig>(this.Path());
        }
    }
}
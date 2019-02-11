using System.Threading.Tasks;

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Health.Index Health()
        {
            return new Scim.Health.Index(this);
        }
    }
}

namespace RingCentral.Paths.Scim.Health
{
    public partial class Index
    {
        public Scim.Index parent;
        public RestClient rc;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            this.rc = this.parent.rc;
        }

        public string Path()
        {
            return parent.Path() + "/health";
        }

        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
        }
    }
}
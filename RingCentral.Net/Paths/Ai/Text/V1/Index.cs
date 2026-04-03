using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Text.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Text.Index parent;
        public Index(Ai.Text.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v1";
        }

    }
}

namespace RingCentral.Paths.Ai.Text
{
    public partial class Index
    {
        public Ai.Text.V1.Index V1()
        {
            return new Ai.Text.V1.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Brand
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string brandId;
        public Index(Restapi.Dictionary.Index parent, string brandId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.brandId = brandId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && brandId != null)
            {
                return $"{parent.Path()}/brand/{brandId}";
            }
            return $"{parent.Path()}/brand";
        }

    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Brand.Index Brand(string brandId = null)
        {
            return new Restapi.Dictionary.Brand.Index(this, brandId);
        }
    }
}
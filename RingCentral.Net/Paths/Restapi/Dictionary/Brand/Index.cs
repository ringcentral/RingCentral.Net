namespace RingCentral.Paths.Restapi.Dictionary.Brand
{
    public partial class Index
    {
        public string brandId;
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent, string brandId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.brandId = brandId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && brandId != null) return $"{parent.Path()}/brand/{brandId}";
            return $"{parent.Path()}/brand";
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Brand.Index Brand(string brandId = null)
        {
            return new Brand.Index(this, brandId);
        }
    }
}
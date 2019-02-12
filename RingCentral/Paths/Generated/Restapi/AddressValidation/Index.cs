namespace RingCentral.Paths.Restapi.AddressValidation
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/address-validation";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.AddressValidation.Index AddressValidation()
        {
            return new Restapi.AddressValidation.Index(this);
        }
    }
}
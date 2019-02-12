namespace RingCentral.Paths.Restapi.AddressValidation.Emergency
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.AddressValidation.Index parent;

        public Index(Restapi.AddressValidation.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/emergency";
        }
    }
}

namespace RingCentral.Paths.Restapi.AddressValidation
{
    public partial class Index
    {
        public Restapi.AddressValidation.Emergency.Index Emergency()
        {
            return new Restapi.AddressValidation.Emergency.Index(this);
        }
    }
}
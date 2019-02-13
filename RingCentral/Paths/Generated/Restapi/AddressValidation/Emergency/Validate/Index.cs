using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.AddressValidation.Emergency.Validate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.AddressValidation.Emergency.Index parent;

        public Index(Restapi.AddressValidation.Emergency.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/validate";
        }

        public async Task<string> Post(RingCentral.ValidateEmergencyAddress validateEmergencyAddress)
        {
            return await rc.Post<string>(this.Path(), validateEmergencyAddress);
        }

        public async Task<string> Post(object validateEmergencyAddress)
        {
            return await rc.Post<string>(this.Path(), validateEmergencyAddress);
        }
    }
}

namespace RingCentral.Paths.Restapi.AddressValidation.Emergency
{
    public partial class Index
    {
        public Restapi.AddressValidation.Emergency.Validate.Index Validate()
        {
            return new Restapi.AddressValidation.Emergency.Validate.Index(this);
        }
    }
}
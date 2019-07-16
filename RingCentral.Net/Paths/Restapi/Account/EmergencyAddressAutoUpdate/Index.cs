namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/emergency-address-auto-update";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Index EmergencyAddressAutoUpdate()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Index(this);
        }
    }
}
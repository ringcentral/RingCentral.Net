namespace RingCentral.Paths.Restapi.V2.Accounts.Devices
{
    public partial class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/devices";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Devices.Index Devices()
        {
            return new Devices.Index(this);
        }
    }
}
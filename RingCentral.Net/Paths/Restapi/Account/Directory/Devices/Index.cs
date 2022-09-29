namespace RingCentral.Paths.Restapi.Account.Directory.Devices
{
    public partial class Index
    {
        public Directory.Index parent;
        public RestClient rc;

        public Index(Directory.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/devices";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Directory
{
    public partial class Index
    {
        public Devices.Index Devices()
        {
            return new Devices.Index(this);
        }
    }
}
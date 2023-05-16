namespace RingCentral.Paths.Restapi.ClientInfo
{
    public partial class Index
    {
        public Restapi.Index parent;
        public RestClient rc;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/client-info";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public ClientInfo.Index ClientInfo()
        {
            return new ClientInfo.Index(this);
        }
    }
}
namespace RingCentral.Paths.Rcvideo.V2.Bridges.Pin
{
    public partial class Index
    {
        public Bridges.Index parent;
        public RestClient rc;

        public Index(Bridges.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/pin";
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V2.Bridges
{
    public partial class Index
    {
        public Pin.Index Pin()
        {
            return new Pin.Index(this);
        }
    }
}
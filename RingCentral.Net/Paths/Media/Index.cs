namespace RingCentral.Paths.Media
{
    public partial class Index
    {
        public RestClient rc;

        public Index(RestClient rc)
        {
            this.rc = rc;
        }

        public string Path()
        {
            return "/media";
        }
    }
}

namespace RingCentral
{
    public partial class RestClient
    {
        public Paths.Media.Index Media()
        {
            return new Paths.Media.Index(this);
        }
    }
}
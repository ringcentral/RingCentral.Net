namespace RingCentral.Paths.V1_0
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
            return "/v1.0";
        }
    }
}

namespace RingCentral
{
    public partial class RestClient
    {
        public Paths.V1_0.Index V1_0()
        {
            return new Paths.V1_0.Index(this);
        }
    }
}
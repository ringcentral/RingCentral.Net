namespace RingCentral.Paths.Ai
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
            return "/ai";
        }
    }
}
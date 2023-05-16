namespace RingCentral.Paths.Analytics
{
    public partial class Index
    {
        public RestClient rc;

        public Index(RestClient rc)
        {
            this.rc = rc;
        }

        public string Path(bool withParameter = false)
        {
            return "/analytics";
        }
    }
}
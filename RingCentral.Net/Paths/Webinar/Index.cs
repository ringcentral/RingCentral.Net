namespace RingCentral.Paths.Webinar
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
            return "/webinar";
        }
    }
}
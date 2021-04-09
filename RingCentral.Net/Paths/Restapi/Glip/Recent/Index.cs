namespace RingCentral.Paths.Restapi.Glip.Recent
{
    public partial class Index
    {
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/recent";
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Recent.Index Recent()
        {
            return new Recent.Index(this);
        }
    }
}
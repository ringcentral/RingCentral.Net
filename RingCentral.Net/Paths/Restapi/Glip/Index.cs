namespace RingCentral.Paths.Restapi.Glip
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

        public string Path()
        {
            return $"{parent.Path()}/glip";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Glip.Index Glip()
        {
            return new Glip.Index(this);
        }
    }
}
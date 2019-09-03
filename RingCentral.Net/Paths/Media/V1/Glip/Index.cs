namespace RingCentral.Paths.Media.V1.Glip
{
    public partial class Index
    {
        public RestClient rc;
        public Media.V1.Index parent;

        public Index(Media.V1.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/glip";
        }
    }
}

namespace RingCentral.Paths.Media.V1
{
    public partial class Index
    {
        public Media.V1.Glip.Index Glip()
        {
            return new Media.V1.Glip.Index(this);
        }
    }
}
namespace RingCentral.Paths.Media.V1
{
    public partial class Index
    {
        public RestClient rc;
        public Media.Index parent;

        public Index(Media.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/v1";
        }
    }
}

namespace RingCentral.Paths.Media
{
    public partial class Index
    {
        public Media.V1.Index V1()
        {
            return new Media.V1.Index(this);
        }
    }
}
namespace RingCentral.Paths.Restapi.V2
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v2";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public V2.Index V2()
        {
            return new V2.Index(this);
        }
    }
}
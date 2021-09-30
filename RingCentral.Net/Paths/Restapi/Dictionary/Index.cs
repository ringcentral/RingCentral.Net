namespace RingCentral.Paths.Restapi.Dictionary
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
            return $"{parent.Path()}/dictionary";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Dictionary.Index Dictionary()
        {
            return new Dictionary.Index(this);
        }
    }
}
namespace RingCentral.Paths.Restapi.NumberPorting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Index parent;

        public Index(Restapi.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/number-porting";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.NumberPorting.Index NumberPorting()
        {
            return new Restapi.NumberPorting.Index(this);
        }
    }
}
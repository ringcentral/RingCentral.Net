namespace RingCentral.Paths.Webinar.History.V1.Company
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/company";
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Company.Index Company()
        {
            return new Company.Index(this);
        }
    }
}
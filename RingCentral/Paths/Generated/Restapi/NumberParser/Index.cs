namespace RingCentral.Paths.Restapi.NumberParser
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
            return $"{parent.Path()}/number-parser";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public Restapi.NumberParser.Index NumberParser()
        {
            return new Restapi.NumberParser.Index(this);
        }
    }
}
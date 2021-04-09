namespace RingCentral.Paths.Restapi.NumberParser
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
            return $"{parent.Path()}/number-parser";
        }
    }
}

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public NumberParser.Index NumberParser()
        {
            return new NumberParser.Index(this);
        }
    }
}
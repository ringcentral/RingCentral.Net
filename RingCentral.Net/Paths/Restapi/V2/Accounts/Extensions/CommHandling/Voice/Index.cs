namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public CommHandling.Index parent;
        public RestClient rc;

        public Index(CommHandling.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/voice";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling
{
    public partial class Index
    {
        public Voice.Index Voice()
        {
            return new Voice.Index(this);
        }
    }
}
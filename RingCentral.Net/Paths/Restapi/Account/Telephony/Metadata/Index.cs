namespace RingCentral.Paths.Restapi.Account.Telephony.Metadata
{
    public partial class Index
    {
        public Telephony.Index parent;
        public RestClient rc;

        public Index(Telephony.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/metadata";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Metadata.Index Metadata()
        {
            return new Metadata.Index(this);
        }
    }
}
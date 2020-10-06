namespace RingCentral.Paths.Restapi.Account.Meeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Meeting.Index Meeting()
        {
            return new Restapi.Account.Meeting.Index(this);
        }
    }
}
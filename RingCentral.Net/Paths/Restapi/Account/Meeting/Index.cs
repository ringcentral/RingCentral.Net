namespace RingCentral.Paths.Restapi.Account.Meeting
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
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
        public Meeting.Index Meeting()
        {
            return new Meeting.Index(this);
        }
    }
}
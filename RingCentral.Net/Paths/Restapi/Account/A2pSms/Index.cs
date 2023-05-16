namespace RingCentral.Paths.Restapi.Account.A2pSms
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/a2p-sms";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public A2pSms.Index A2pSms()
        {
            return new A2pSms.Index(this);
        }
    }
}
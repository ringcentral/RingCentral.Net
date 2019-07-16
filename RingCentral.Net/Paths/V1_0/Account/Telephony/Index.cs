namespace RingCentral.Paths.V1_0.Account.Telephony
{
    public partial class Index
    {
        public RestClient rc;
        public V1_0.Account.Index parent;

        public Index(V1_0.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/telephony";
        }
    }
}

namespace RingCentral.Paths.V1_0.Account
{
    public partial class Index
    {
        public V1_0.Account.Telephony.Index Telephony()
        {
            return new V1_0.Account.Telephony.Index(this);
        }
    }
}
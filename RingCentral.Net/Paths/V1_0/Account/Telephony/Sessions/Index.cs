namespace RingCentral.Paths.V1_0.Account.Telephony.Sessions
{
    public partial class Index
    {
        public RestClient rc;
        public string telephonySessionId;
        public V1_0.Account.Telephony.Index parent;

        public Index(V1_0.Account.Telephony.Index parent, string telephonySessionId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.telephonySessionId = telephonySessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && telephonySessionId != null)
            {
                return $"{parent.Path()}/sessions/{telephonySessionId}";
            }

            return $"{parent.Path()}/sessions";
        }
    }
}

namespace RingCentral.Paths.V1_0.Account.Telephony
{
    public partial class Index
    {
        public V1_0.Account.Telephony.Sessions.Index Sessions(string telephonySessionId = null)
        {
            return new V1_0.Account.Telephony.Sessions.Index(this, telephonySessionId);
        }
    }
}
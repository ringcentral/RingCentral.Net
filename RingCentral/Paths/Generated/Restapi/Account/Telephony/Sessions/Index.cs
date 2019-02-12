using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public RestClient rc;
        public string sessionId;
        public Restapi.Account.Telephony.Index parent;

        public Index(Restapi.Account.Telephony.Index parent, string sessionId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.sessionId = sessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && sessionId != null)
            {
                return $"{parent.Path()}/sessions/{sessionId}";
            }

            return $"{parent.Path()}/sessions";
        }

        public async Task<RingCentral.CallSessionObject> Get()
        {
            if (this.sessionId == null)
            {
                throw new System.ArgumentNullException("sessionId");
            }

            return await rc.Get<RingCentral.CallSessionObject>(this.Path());
        }

        public async Task<string> Delete()
        {
            if (this.sessionId == null)
            {
                throw new System.ArgumentNullException("sessionId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Index Sessions(string sessionId = null)
        {
            return new Restapi.Account.Telephony.Sessions.Index(this, sessionId);
        }
    }
}
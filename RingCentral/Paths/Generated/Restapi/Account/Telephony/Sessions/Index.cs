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

        public async Task<RingCentral.CallSessionObject> Get(GetQueryParams queryParams = null)
        {
            if (this.sessionId == null)
            {
                throw new System.ArgumentNullException("sessionId");
            }

            return await rc.Get<RingCentral.CallSessionObject>(this.Path(), queryParams);
        }

        public async Task<RingCentral.CallSessionObject> Get(object queryParams)
        {
            if (this.sessionId == null)
            {
                throw new System.ArgumentNullException("sessionId");
            }

            return await rc.Get<RingCentral.CallSessionObject>(this.Path(), queryParams);
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

    public class GetQueryParams
    {
        // The date and time of a call session latest change
        public string timestamp;

        // The time frame of awaiting for a status change before sending the resulting one in response
        public string timeout;
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
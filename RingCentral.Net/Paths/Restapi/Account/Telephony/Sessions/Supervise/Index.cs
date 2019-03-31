using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Supervise
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/supervise";
        }

        // Operation: Supervise Call
        // Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/supervise
        public async Task<RingCentral.SuperviseCallSession> Post(
            RingCentral.SuperviseCallSessionRequest superviseCallSessionRequest)
        {
            return await rc.Post<RingCentral.SuperviseCallSession>(this.Path(), superviseCallSessionRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Supervise.Index Supervise()
        {
            return new Restapi.Account.Telephony.Sessions.Supervise.Index(this);
        }
    }
}
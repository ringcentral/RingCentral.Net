using System.Threading.Tasks;
using System.Threading;

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

        /// <summary>
        /// Operation: Supervise Call Session
        /// Rate Limit Group: Light
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise
        /// </summary>
        public async Task<RingCentral.SuperviseCallSession> Post(
            RingCentral.SuperviseCallSessionRequest superviseCallSessionRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.SuperviseCallSession>(this.Path(), superviseCallSessionRequest, null,
                cancellationToken);
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
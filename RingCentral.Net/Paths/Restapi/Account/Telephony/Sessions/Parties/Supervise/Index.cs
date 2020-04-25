using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Supervise
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Parties.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Parties.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/supervise";
        }

        /// <summary>
        /// Operation: Supervise Call Party
        /// Rate Limit Group: Light
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise
        /// </summary>
        public async Task<RingCentral.PartySuperviseResponse> Post(
            RingCentral.PartySuperviseRequest partySuperviseRequest, CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.PartySuperviseResponse>(this.Path(), partySuperviseRequest, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Supervise.Index Supervise()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Supervise.Index(this);
        }
    }
}
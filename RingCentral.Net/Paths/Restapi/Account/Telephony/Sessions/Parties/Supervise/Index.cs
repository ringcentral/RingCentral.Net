using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Allows to monitor a call party in 'Listen' mode. Input parameters are extension number of a monitored user and internal identifier of a supervisor's device. Call session and party identifiers should be specified in path. Please note that for this method dual channel audio flow is supported, which means that you need to make one more request for monitoring the second participant of a call. And as a result of each monitoring request the client recieves SIP invite with the following header `p-rc-api-monitoring-ids` containing IDs of the monitored party and session. The flow is supported for calls with no more than 2 participants. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.PartySuperviseResponse> Post(
            RingCentral.PartySuperviseRequest partySuperviseRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.PartySuperviseResponse>(this.Path(), partySuperviseRequest, null,
                restRequestConfig);
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
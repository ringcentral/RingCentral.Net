using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Supervise
{
    public class Index
    {
        public Parties.Index parent;
        public RestClient rc;

        public Index(Parties.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/supervise";
        }

        /// <summary>
        ///     Allows to monitor a call party in 'Listen' mode. Input parameters are extension number of a monitored user and
        ///     internal identifier of a supervisor's device. Call session and party identifiers should be specified in path.
        ///     Please note that for this method dual channel audio flow is supported, which means that you need to make one more
        ///     request for monitoring the second participant of a call. And as a result of each monitoring request the client
        ///     receives SIP invite with the following header `p-rc-api-monitoring-ids` containing IDs of the monitored party and
        ///     session. The flow is supported for calls with no more than 2 participants. Currently this method is supported for
        ///     Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<PartySuperviseResponse> Post(PartySuperviseRequest partySuperviseRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<PartySuperviseResponse>(Path(), partySuperviseRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Supervise.Index Supervise()
        {
            return new Supervise.Index(this);
        }
    }
}
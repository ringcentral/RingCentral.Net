using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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
        /// Allows to monitor a call session in 'Listen' mode. Input parameters should contain internal identifiers of a monitored user and a supervisor's device. Call session should be specified in path. Please note that this method supports single channel audio flow, which means that audio of both call participants is mixed and delivered to the supervisor in single audio channel. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.SuperviseCallSession> Post(
            RingCentral.SuperviseCallSessionRequest superviseCallSessionRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.SuperviseCallSession>(this.Path(), superviseCallSessionRequest, null,
                restRequestConfig);
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
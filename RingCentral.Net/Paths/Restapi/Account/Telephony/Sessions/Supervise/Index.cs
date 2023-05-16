using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Supervise
{
    public class Index
    {
        public Sessions.Index parent;
        public RestClient rc;

        public Index(Sessions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/supervise";
        }

        /// <summary>
        ///     Allows to monitor a call session in 'Listen' mode. Input parameters should contain internal identifiers of a
        ///     monitored user and a supervisor's device. Call session should be specified in path. Please note that this method
        ///     supports single channel audio flow, which means that audio of both call participants is mixed and delivered to the
        ///     supervisor in single audio channel. Currently this method is supported for Softphone/Hardphone only, since device
        ///     IDs for WebRTC/Mobile apps cannot be obtained.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<SuperviseCallSessionResponse> Post(SuperviseCallSessionRequest superviseCallSessionRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<SuperviseCallSessionResponse>(Path(), superviseCallSessionRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Supervise.Index Supervise()
        {
            return new Supervise.Index(this);
        }
    }
}
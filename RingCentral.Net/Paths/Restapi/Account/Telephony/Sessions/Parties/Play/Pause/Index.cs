using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Play.Pause
{
    public class Index
    {
        public Play.Index parent;
        public RestClient rc;

        public Index(Play.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/pause";
        }

        /// <summary>
        ///     Pause playing audio file.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/play/{playId}/pause
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Play
{
    public partial class Index
    {
        public Pause.Index Pause()
        {
            return new Pause.Index(this);
        }
    }
}
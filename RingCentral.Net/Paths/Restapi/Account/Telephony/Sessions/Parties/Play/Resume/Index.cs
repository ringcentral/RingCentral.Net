using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Play.Resume
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
            return $"{parent.Path()}/resume";
        }

        /// <summary>
        ///     Resume playing audio file.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/play/{playId}/resume
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
        public Resume.Index Resume()
        {
            return new Resume.Index(this);
        }
    }
}
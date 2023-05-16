using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Conference
{
    public class Index
    {
        public Telephony.Index parent;
        public RestClient rc;

        public Index(Telephony.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/conference";
        }

        /// <summary>
        ///     Initiates a conference call session.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/conference
        ///     Rate Limit Group: Heavy
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallSession> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallSession>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Conference.Index Conference()
        {
            return new Conference.Index(this);
        }
    }
}
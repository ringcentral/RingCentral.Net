using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Ignore
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

        public string Path()
        {
            return $"{parent.Path()}/ignore";
        }

        /// <summary>
        ///     Ignores a call to a call queue agent in `Setup` or `Proceeding` state.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Post(IgnoreRequestBody ignoreRequestBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), ignoreRequestBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Ignore.Index Ignore()
        {
            return new Ignore.Index(this);
        }
    }
}
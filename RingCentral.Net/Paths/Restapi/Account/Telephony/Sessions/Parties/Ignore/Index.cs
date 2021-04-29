using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Ignore
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
            return $"{parent.Path()}/ignore";
        }

        /// <summary>
        /// Ignores a call to a call queue agent in `Setup` or `Proceeding` state.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<string> Post(RingCentral.IgnoreRequestBody ignoreRequestBody,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), ignoreRequestBody, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Ignore.Index Ignore()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Ignore.Index(this);
        }
    }
}
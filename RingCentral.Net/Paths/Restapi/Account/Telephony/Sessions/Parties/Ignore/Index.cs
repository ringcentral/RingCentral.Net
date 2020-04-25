using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Ignore Call in Queue
        /// Rate Limit Group: Light
        /// Http Post /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore
        /// </summary>
        public async Task<string> Post(RingCentral.IgnoreRequestBody ignoreRequestBody,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), ignoreRequestBody, null, cancellationToken);
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
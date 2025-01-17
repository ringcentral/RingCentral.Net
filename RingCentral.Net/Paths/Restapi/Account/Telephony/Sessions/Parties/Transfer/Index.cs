using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Transfer
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
            return $"{parent.Path()}/transfer";
        }

        /// <summary>
        ///     Transfers an answered call to the specified call party. Applicable for a call session in "Answered" or "Hold"
        ///     state.
        ///     HTTP Method: post
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallParty> Post(TransferTarget transferTarget,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CallParty>(Path(), transferTarget, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Transfer.Index Transfer()
        {
            return new Transfer.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Move
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
            return $"{parent.Path()}/move";
        }

        /// <summary>
        ///     Either moves call parties to RCC Conference by a Secretary or moves call parties to RCV Conference
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/move
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Post(MovePartiesRequest movePartiesRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), movePartiesRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Move.Index Move()
        {
            return new Move.Index(this);
        }
    }
}
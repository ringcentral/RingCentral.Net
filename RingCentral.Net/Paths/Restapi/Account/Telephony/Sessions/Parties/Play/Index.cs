using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Play
{
    public partial class Index
    {
        public Parties.Index parent;
        public string playId;
        public RestClient rc;

        public Index(Parties.Index parent, string playId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.playId = playId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && playId != null) return $"{parent.Path()}/play/{playId}";
            return $"{parent.Path()}/play";
        }

        /// <summary>
        ///     Stop playing audio file into a party
        ///     HTTP Method: delete
        ///     Endpoint:
        ///     /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/play/{playId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (playId == null) throw new ArgumentException("Parameter cannot be null", nameof(playId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Play.Index Play(string playId = null)
        {
            return new Play.Index(this, playId);
        }
    }
}
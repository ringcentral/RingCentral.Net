using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public RestClient rc;
        public string telephonySessionId;
        public Restapi.Account.Telephony.Index parent;

        public Index(Restapi.Account.Telephony.Index parent, string telephonySessionId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.telephonySessionId = telephonySessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && telephonySessionId != null)
            {
                return $"{parent.Path()}/sessions/{telephonySessionId}";
            }

            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        /// Operation: Get Call Session Status
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.CallSession> Get(ReadCallSessionStatusParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            if (this.telephonySessionId == null)
            {
                throw new System.ArgumentNullException("telephonySessionId");
            }

            return await rc.Get<RingCentral.CallSession>(this.Path(), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Drop Call Session
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// User Permission: undefined
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.telephonySessionId == null)
            {
                throw new System.ArgumentNullException("telephonySessionId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Index Sessions(string telephonySessionId = null)
        {
            return new Restapi.Account.Telephony.Sessions.Index(this, telephonySessionId);
        }
    }
}
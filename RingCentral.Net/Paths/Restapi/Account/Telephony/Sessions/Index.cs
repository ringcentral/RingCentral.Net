using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Index parent;
        public string telephonySessionId;

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
        /// Returns the status of a call session by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallSessionObject> Get(
            RingCentral.ReadCallSessionStatusParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallSessionObject>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Drops a call session.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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
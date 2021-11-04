using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions
{
    public partial class Index
    {
        public Telephony.Index parent;
        public RestClient rc;
        public string telephonySessionId;

        public Index(Telephony.Index parent, string telephonySessionId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.telephonySessionId = telephonySessionId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && telephonySessionId != null) return $"{parent.Path()}/sessions/{telephonySessionId}";

            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        ///     Returns the status of a call session by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<CallSessionObject> Get(
            ReadCallSessionStatusParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (telephonySessionId == null)
                throw new ArgumentException("Parameter cannot be null", nameof(telephonySessionId));

            return await rc.Get<CallSessionObject>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Drops a call session.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}
        ///     Rate Limit Group: Light
        ///     App Permission: CallControl
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (telephonySessionId == null)
                throw new ArgumentException("Parameter cannot be null", nameof(telephonySessionId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony
{
    public partial class Index
    {
        public Sessions.Index Sessions(string telephonySessionId = null)
        {
            return new Sessions.Index(this, telephonySessionId);
        }
    }
}
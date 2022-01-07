using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.CustomGreetings
{
    public class Index
    {
        public string greetingId;
        public CallRecording.Index parent;
        public RestClient rc;

        public Index(CallRecording.Index parent, string greetingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null) return $"{parent.Path()}/custom-greetings/{greetingId}";
            return $"{parent.Path()}/custom-greetings";
        }

        /// <summary>
        ///     Returns call recording custom greetings.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<CallRecordingCustomGreetings> Get(
            ListCallRecordingCustomGreetingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallRecordingCustomGreetings>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Deletes call recording custom greetings.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyInfo
        /// </summary>
        public async Task<string> DeleteAll(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes call recording custom greeting(s).
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings/{greetingId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyInfo
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (greetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(greetingId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public CustomGreetings.Index CustomGreetings(string greetingId = null)
        {
            return new CustomGreetings.Index(this, greetingId);
        }
    }
}
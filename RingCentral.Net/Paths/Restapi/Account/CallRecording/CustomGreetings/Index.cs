using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallRecording.CustomGreetings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallRecording.Index parent;
        public string greetingId;

        public Index(Restapi.Account.CallRecording.Index parent, string greetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null)
            {
                return $"{parent.Path()}/custom-greetings/{greetingId}";
            }

            return $"{parent.Path()}/custom-greetings";
        }

        /// <summary>
        /// Returns call recording custom greetings.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingCustomGreetings> Get(
            RingCentral.ListCallRecordingCustomGreetingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallRecordingCustomGreetings>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes call recording custom greetings.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<string> DeleteAll(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Deletes call recording custom greeting(s).
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/custom-greetings/{greetingId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.CustomGreetings.Index CustomGreetings(string greetingId = null)
        {
            return new Restapi.Account.CallRecording.CustomGreetings.Index(this, greetingId);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.CustomGreetings
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Account.CallRecording.Index parent;

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
        /// Operation: Get Call Recording Custom Greeting List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording/custom-greetings
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingCustomGreetings> Get(
            ListCallRecordingCustomGreetingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallRecordingCustomGreetings>(this.Path(false), queryParams,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Call Recording Custom Greeting
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

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
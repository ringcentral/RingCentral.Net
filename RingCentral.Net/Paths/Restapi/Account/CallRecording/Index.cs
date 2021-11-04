using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-recording";
        }

        /// <summary>
        ///     Returns call recording settings.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<CallRecordingSettingsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallRecordingSettingsResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates current call recording settings.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyInfo
        /// </summary>
        public async Task<CallRecordingSettingsResource> Put(
            CallRecordingSettingsResource callRecordingSettingsResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CallRecordingSettingsResource>(Path(), callRecordingSettingsResource,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CallRecording.Index CallRecording()
        {
            return new CallRecording.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-recording";
        }

        /// <summary>
        /// Returns call recording settings.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingSettingsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallRecordingSettingsResource>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates current call recording settings.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<RingCentral.CallRecordingSettingsResource> Put(
            RingCentral.CallRecordingSettingsResource callRecordingSettingsResource,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.CallRecordingSettingsResource>(this.Path(), callRecordingSettingsResource,
                null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.Index CallRecording()
        {
            return new Restapi.Account.CallRecording.Index(this);
        }
    }
}
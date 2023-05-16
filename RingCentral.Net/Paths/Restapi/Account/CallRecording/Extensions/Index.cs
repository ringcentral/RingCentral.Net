using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.Extensions
{
    public class Index
    {
        public CallRecording.Index parent;
        public RestClient rc;

        public Index(CallRecording.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/extensions";
        }

        /// <summary>
        ///     Returns the list of extensions to be recorded.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recording/extensions
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<CallRecordingExtensions> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CallRecordingExtensions>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Extensions.Index Extensions()
        {
            return new Extensions.Index(this);
        }
    }
}
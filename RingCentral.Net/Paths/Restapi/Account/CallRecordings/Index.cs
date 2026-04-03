using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallRecordings
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
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/call-recordings";
        }
        /// <summary>
        /// Deletes company call recordings by their IDs. *Please note:* This method deletes the recording file itself,
        /// not the record of it in the call log.
        /// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-recordings
        /// Rate Limit Group: Heavy
        /// App Permission: EditCallLog
        /// User Permission: EditCompanyCallRecordings
        /// </summary>
        public async Task<string> Delete(RingCentral.CallRecordingIds callRecordingIds, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), callRecordingIds, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallRecordings.Index CallRecordings()
        {
            return new Restapi.Account.CallRecordings.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallRecording.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallRecording.Index parent;

        public Index(Restapi.Account.CallRecording.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        // Operation: Update Call Recording Extension Settings
        // Http Post /restapi/v1.0/account/{accountId}/call-recording/bulk-assign
        public async Task<string> Post(RingCentral.BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource)
        {
            return await rc.Post<string>(this.Path(), bulkAccountCallRecordingsResource);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallRecording
{
    public partial class Index
    {
        public Restapi.Account.CallRecording.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.CallRecording.BulkAssign.Index(this);
        }
    }
}
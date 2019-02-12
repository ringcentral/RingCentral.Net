using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingRecordings
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/meeting-recordings";
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get()
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MeetingRecordings.Index MeetingRecordings()
        {
            return new Restapi.Account.Extension.MeetingRecordings.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MeetingRecordings
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
            return $"{parent.Path()}/meeting-recordings";
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get()
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MeetingRecordings.Index MeetingRecordings()
        {
            return new Restapi.Account.MeetingRecordings.Index(this);
        }
    }
}
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

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(
            ListUserMeetingRecordingsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.ListMeetingRecordingsResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.ListMeetingRecordingsResponse>(this.Path(), queryParams);
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
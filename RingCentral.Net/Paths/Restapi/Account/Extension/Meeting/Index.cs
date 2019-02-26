using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public RestClient rc;
        public string meetingId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string meetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.meetingId = meetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && meetingId != null)
            {
                return $"{parent.Path()}/meeting/{meetingId}";
            }

            return $"{parent.Path()}/meeting";
        }

        // Operation: listMeetings
        public async Task<RingCentral.MeetingsResource> List()
        {
            return await rc.Get<RingCentral.MeetingsResource>(this.Path(false));
        }

        // Operation: createMeeting
        public async Task<string> Post(RingCentral.MeetingRequestResource meetingRequestResource)
        {
            return await rc.Post<string>(this.Path(false), meetingRequestResource);
        }

        // Operation: loadMeeting
        public async Task<RingCentral.MeetingResponseResource> Get()
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Get<RingCentral.MeetingResponseResource>(this.Path());
        }

        // Operation: updateMeeting
        public async Task<RingCentral.MeetingResponseResource> Put(
            RingCentral.MeetingRequestResource meetingRequestResource)
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Put<RingCentral.MeetingResponseResource>(this.Path(), meetingRequestResource);
        }

        // Operation: deleteMeeting
        public async Task<string> Delete()
        {
            if (this.meetingId == null)
            {
                throw new System.ArgumentNullException("meetingId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.Index Meeting(string meetingId = null)
        {
            return new Restapi.Account.Extension.Meeting.Index(this, meetingId);
        }
    }
}
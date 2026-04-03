using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants.Self
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.History.V1.Webinars.Sessions.Participants.Index parent;
        public Index(Webinar.History.V1.Webinars.Sessions.Participants.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/self";
        }
        /// <summary>
        /// Returns the participant information specific to a webinar session. Accessible by any authenticated participant.
        /// For a non-authenticated participant, API returns error.
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants/self
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.ParticipantReducedModel> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ParticipantReducedModel>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants
{
    public partial class Index
    {
        public Webinar.History.V1.Webinars.Sessions.Participants.Self.Index Self()
        {
            return new Webinar.History.V1.Webinars.Sessions.Participants.Self.Index(this);
        }
    }
}
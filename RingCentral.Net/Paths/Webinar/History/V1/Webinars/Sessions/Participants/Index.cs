using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants
{
    public partial class Index
    {
        public RestClient rc;
        public Webinar.History.V1.Webinars.Sessions.Index parent;
        public Index(Webinar.History.V1.Webinars.Sessions.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/participants";
        }
        /// <summary>
        /// Returns the list of participants of a given Webinar Session (host interface).
        /// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
        public async Task<RingCentral.ParticipantListResource> Get(RingCentral.RcwHistoryListParticipantsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.ParticipantListResource>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Webinar.History.V1.Webinars.Sessions.Participants.Index Participants()
        {
            return new Webinar.History.V1.Webinars.Sessions.Participants.Index(this);
        }
    }
}
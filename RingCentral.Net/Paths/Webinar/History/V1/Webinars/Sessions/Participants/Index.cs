using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants
{
    public class Index
    {
        public Sessions.Index parent;
        public RestClient rc;

        public Index(Sessions.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/participants";
        }

        /// <summary>
        ///     Returns the list of participants of a given Webinar Session.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<ParticipantListResource> Get(RcwHistoryListParticipantsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ParticipantListResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
{
    public partial class Index
    {
        public Participants.Index Participants()
        {
            return new Participants.Index(this);
        }
    }
}
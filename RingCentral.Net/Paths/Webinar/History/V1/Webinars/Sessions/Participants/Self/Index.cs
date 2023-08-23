using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants.Self
{
    public class Index
    {
        public Participants.Index parent;
        public RestClient rc;

        public Index(Participants.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/self";
        }

        /// <summary>
        ///     Returns the participant information specific to a webinar session. Accessible by any authenticated participant.
        ///     For a non-authenticated participant, API returns error.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}/participants/self
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<ParticipantReducedModel> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ParticipantReducedModel>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions.Participants
{
    public partial class Index
    {
        public Self.Index Self()
        {
            return new Self.Index(this);
        }
    }
}
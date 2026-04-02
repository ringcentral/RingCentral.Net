using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Webinars.Sessions
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.History.V1.Webinars.Index parent;
public string sessionId;
public Index(Webinar.History.V1.Webinars.Index parent, string sessionId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.sessionId = sessionId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && sessionId != null)
            {
                return $"{parent.Path()}/sessions/{sessionId}";
            }
            return $"{parent.Path()}/sessions";
        }
        /// <summary>
        /// Returns a historical webinar Session by ID. Access allowed to participants with original role as Host or CoHost.
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}/sessions/{sessionId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.HistorySessionResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (sessionId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(sessionId));
    }return await rc.Get<RingCentral.HistorySessionResource>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.History.V1.Webinars
{
    public partial class Index
    {
        public Webinar.History.V1.Webinars.Sessions.Index Sessions(string sessionId = null)
        {
            return new Webinar.History.V1.Webinars.Sessions.Index(this, sessionId);
        }
    }
}
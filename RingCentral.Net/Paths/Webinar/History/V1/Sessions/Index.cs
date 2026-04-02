using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Sessions
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.History.V1.Index parent;
public Index(Webinar.History.V1.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sessions";
        }
        /// <summary>
        /// Returns the list of historical Webinar Sessions hosted by a current authorized user
/// sorted by 'endTime' in the descending order. Depending on a session status 'endTime' can
/// represent actual end time or scheduled end time.
/// 
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/sessions
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.SessionGlobalListResource> Get(RingCentral.RcwHistoryListAllSessionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.SessionGlobalListResource>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Webinar.History.V1.Sessions.Index Sessions()
        {
            return new Webinar.History.V1.Sessions.Index(this);
        }
    }
}
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Configuration.V1.Sessions
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Configuration.V1.Index parent;
public Index(Webinar.Configuration.V1.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sessions";
        }
        /// <summary>
        /// Returns the list of Webinar Sessions hosted by a current authorized user sorted by
/// 'scheduledStartTime' or 'creationTime' (if 'scheduledStartTime' is not set) in the ascending order
/// 
        /// HTTP Method: get
        /// Endpoint: /webinar/configuration/v1/sessions
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.WcsSessionGlobalListResource> Get(RingCentral.RcwConfigListAllSessionsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.WcsSessionGlobalListResource>(this.Path(), queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Webinar.Configuration.V1.Sessions.Index Sessions()
        {
            return new Webinar.Configuration.V1.Sessions.Index(this);
        }
    }
}
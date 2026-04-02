using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.History.V1.Webinars
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.History.V1.Index parent;
public string webinarId;
public Index(Webinar.History.V1.Index parent, string webinarId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.webinarId = webinarId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && webinarId != null)
            {
                return $"{parent.Path()}/webinars/{webinarId}";
            }
            return $"{parent.Path()}/webinars";
        }
        /// <summary>
        /// Returns a historical webinar information by ID (host interface)
        /// HTTP Method: get
        /// Endpoint: /webinar/history/v1/webinars/{webinarId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadWebinars
        /// </summary>
  public async Task<RingCentral.HistoryWebinarResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (webinarId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(webinarId));
    }return await rc.Get<RingCentral.HistoryWebinarResource>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Webinar.History.V1.Webinars.Index Webinars(string webinarId = null)
        {
            return new Webinar.History.V1.Webinars.Index(this, webinarId);
        }
    }
}
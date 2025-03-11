using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Webinars
{
    public partial class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string webinarId;

        public Index(V1.Index parent, string webinarId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.webinarId = webinarId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webinarId != null) return $"{parent.Path()}/webinars/{webinarId}";
            return $"{parent.Path()}/webinars";
        }

        /// <summary>
        ///     Returns a historical webinar information by ID (host interface)
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/webinars/{webinarId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WebinarResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (webinarId == null) throw new ArgumentException("Parameter cannot be null", nameof(webinarId));
            return await rc.Get<WebinarResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Webinars.Index Webinars(string webinarId = null)
        {
            return new Webinars.Index(this, webinarId);
        }
    }
}
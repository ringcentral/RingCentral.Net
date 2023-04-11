using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.Configuration.V1.Sessions
{
    public class Index
    {
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        ///     Returns the list of Webinar Sessions hosted by a current authorized user sorted by
        ///     'scheduledStartTime' or 'creationTime' (if 'scheduledStartTime' is not set) in the ascending order
        ///     HTTP Method: get
        ///     Endpoint: /webinar/configuration/v1/sessions
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<WcsSessionGlobalListResource> Get(RcwConfigListAllSessionsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<WcsSessionGlobalListResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.Configuration.V1
{
    public partial class Index
    {
        public Sessions.Index Sessions()
        {
            return new Sessions.Index(this);
        }
    }
}
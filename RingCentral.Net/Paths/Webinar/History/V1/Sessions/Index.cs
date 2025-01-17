using System.Threading.Tasks;

namespace RingCentral.Paths.Webinar.History.V1.Sessions
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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/sessions";
        }

        /// <summary>
        ///     Returns the list of historical Webinar Sessions hosted by a current authorized user
        ///     sorted by 'endTime' in the descending order. Depending on a session status 'endTime' can
        ///     represent actual end time or scheduled end time.
        ///     HTTP Method: get
        ///     Endpoint: /webinar/history/v1/sessions
        ///     Rate Limit Group: Heavy
        ///     App Permission: ReadWebinars
        /// </summary>
        public async Task<SessionGlobalListResource> Get(
            RcwHistoryListAllSessionsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SessionGlobalListResource>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Webinar.History.V1
{
    public partial class Index
    {
        public Sessions.Index Sessions()
        {
            return new Sessions.Index(this);
        }
    }
}
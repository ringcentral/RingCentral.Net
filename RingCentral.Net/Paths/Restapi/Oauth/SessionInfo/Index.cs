using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Oauth.SessionInfo
{
    public class Index
    {
        public Oauth.Index parent;
        public RestClient rc;

        public Index(Oauth.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/session-info";
        }

        /// <summary>
        ///     Returns information about current OAuth session
        ///     HTTP Method: get
        ///     Endpoint: /restapi/oauth/session-info
        ///     Rate Limit Group: Auth
        /// </summary>
        public async Task<SessionInfoResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<SessionInfoResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Oauth
{
    public partial class Index
    {
        public SessionInfo.Index SessionInfo()
        {
            return new SessionInfo.Index(this);
        }
    }
}
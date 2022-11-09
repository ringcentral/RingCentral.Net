using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Preferences
{
    public class Index
    {
        public TeamMessaging.Index parent;
        public RestClient rc;

        public Index(TeamMessaging.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/preferences";
        }

        /// <summary>
        ///     Returns information about user preferences.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/preferences
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPreferencesInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<TMPreferencesInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Preferences.Index Preferences()
        {
            return new Preferences.Index(this);
        }
    }
}
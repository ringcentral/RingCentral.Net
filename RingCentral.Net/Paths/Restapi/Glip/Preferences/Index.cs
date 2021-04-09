using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Preferences
{
    public class Index
    {
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/preferences
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPreferencesInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipPreferencesInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Preferences.Index Preferences()
        {
            return new Preferences.Index(this);
        }
    }
}
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Preferences
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/preferences";
        }

        /// <summary>
        /// Operation: Get Preferences
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/preferences
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipPreferencesInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GlipPreferencesInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Preferences.Index Preferences()
        {
            return new Restapi.Glip.Preferences.Index(this);
        }
    }
}
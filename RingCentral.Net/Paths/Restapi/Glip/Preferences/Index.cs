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

        // Operation: Get User Preferences
        // Http Get /restapi/v1.0/glip/preferences
        public async Task<RingCentral.GlipPreferencesInfo> Get()
        {
            return await rc.Get<RingCentral.GlipPreferencesInfo>(this.Path());
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
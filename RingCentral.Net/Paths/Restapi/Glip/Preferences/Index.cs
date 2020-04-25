using System.Threading.Tasks;
using System.Threading;

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
        /// Rate Limit Group: Medium
        /// Http Get /restapi/v1.0/glip/preferences
        /// </summary>
        public async Task<RingCentral.GlipPreferencesInfo> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipPreferencesInfo>(this.Path(), null, cancellationToken);
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
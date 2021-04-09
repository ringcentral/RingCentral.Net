using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Everyone
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
            return $"{parent.Path()}/everyone";
        }

        /// <summary>
        ///     Returns information about Everyone chat, which is a company level chat including all employees; assigned with
        ///     specific name.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/everyone
        ///     Rate Limit Group: Light
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipEveryoneInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipEveryoneInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates Everyone chat information. Everyone chat is a company level chat including all employees; assigned with
        ///     specific name.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/{apiVersion}/glip/everyone
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipEveryoneInfo> Patch(
            UpdateGlipEveryoneRequest updateGlipEveryoneRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Patch<GlipEveryoneInfo>(Path(), updateGlipEveryoneRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Everyone.Index Everyone()
        {
            return new Everyone.Index(this);
        }
    }
}
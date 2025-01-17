using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi
{
    public partial class Index
    {
        public string apiVersion;
        public RestClient rc;

        public Index(RestClient rc, string apiVersion = "v1.0")
        {
            this.rc = rc;
            this.apiVersion = apiVersion;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && apiVersion != null) return $"/restapi/{apiVersion}";

            return "/restapi";
        }

        /// <summary>
        ///     Returns current API version(s) and server info.
        ///     HTTP Method: get
        ///     Endpoint: /restapi
        ///     Rate Limit Group: NoThrottling
        /// </summary>
        public async Task<ApiVersionsList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ApiVersionsList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns current API version info by apiVersion.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}
        ///     Rate Limit Group: NoThrottling
        /// </summary>
        public async Task<ApiVersionInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (apiVersion == null) throw new ArgumentException("Parameter cannot be null", nameof(apiVersion));

            return await rc.Get<ApiVersionInfo>(Path(), null, restRequestConfig);
        }
    }
}